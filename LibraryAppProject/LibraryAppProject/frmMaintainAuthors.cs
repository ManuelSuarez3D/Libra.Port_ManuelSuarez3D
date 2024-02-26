using System.ComponentModel;
using System.Data;

namespace LibraryAppProject
{
    public partial class frmMaintainAuthors : Form
    {
        public frmMaintainAuthors()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load
        /// </summary>
        private void frmMaintainAuthors_Load(object sender, EventArgs e)
        {
            try
            {
                LoadFirstAuthor();

                txtFirstName.CausesValidation = false;
                txtLastName.CausesValidation = false;
                txtDescription.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Form Close
        /// </summary>
        private void frmMaintainAuthors_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMdiParent mdiParent = this.MdiParent as frmMdiParent;

            if (mdiParent != null)
            {
                mdiParent.StatusStripProgressBar.Value = 0;
            }

            UpdateStatusLabelStatus(string.Empty);
            UpdateStatusStripRecord(string.Empty);
        }

        #region[Tracker]
        int currentRecord = 0;
        int currentAuthorId = 0;
        int firstAuthorId = 0;
        int lastAuthorId = 0;
        int recordCount = 0;
        int? previousAuthorId;
        int? nextAuthorId;
        #endregion

        #region [Navigation Helpers]
        /// <summary>
        /// Toggle Next/Previous Button
        /// </summary>
        private void NextPreviousButtonManagement()
        {
            pctPrevious.Enabled = previousAuthorId != null;
            pctPrevious.Visible = previousAuthorId != null;
            pctNext.Enabled = nextAuthorId != null;
            pctNext.Visible = nextAuthorId != null;
        }

        /// <summary>
        /// Navigation State
        /// </summary>
        private void NavigationState(bool enableState)
        {
            pctFirst.Enabled = enableState;
            pctPrevious.Enabled = enableState;
            pctNext.Enabled = enableState;
            pctLast.Enabled = enableState;
        }

        /// <summary>
        /// Navigation Clicking
        /// </summary>
        private void Navigation_Handler(object sender, EventArgs e)
        {
            PictureBox b = (PictureBox)sender;
            UpdateStatusLabelStatus(string.Empty);

            switch (b.Name)
            {
                case "pctFirst":
                    currentAuthorId = firstAuthorId;
                    break;
                case "pctLast":
                    currentAuthorId = lastAuthorId;
                    break;
                case "pctPrevious":
                    currentAuthorId = previousAuthorId.Value;
                    break;
                case "pctNext":
                    currentAuthorId = nextAuthorId.Value;
                    break;
            }

            LoadAuthorDetails();
        }
        #endregion

        #region [Retrievers]
        /// <summary>
        /// Load First Author
        /// </summary>
        private void LoadFirstAuthor()
        {
            string sqlGetFirstAuthorId = $"SELECT TOP (1) AuthorId FROM Authors ORDER BY FirstName;";
            object authorId = DataAccess.GetValue(sqlGetFirstAuthorId);

            if (authorId == null)
            {
                pctFirst.Enabled = false;
                pctNext.Enabled = false;
                pctPrevious.Enabled = false;
                pctLast.Enabled = false;

            }
            else
            {
                pctFirst.Enabled = true;
                pctNext.Enabled = true;
                pctPrevious.Enabled = true;
                pctLast.Enabled = true;

                currentAuthorId = Convert.ToInt32(authorId);
                firstAuthorId = currentAuthorId;
            }

            LoadAuthorDetails();
        }

        /// <summary>
        /// Load Author Details
        /// </summary>
        private void LoadAuthorDetails()
        {
            btnCancel.Enabled = false;
            errProvider.Clear();

            string[] sqlStatements = new string[]
            {
                $"SELECT * FROM Authors WHERE AuthorId = {currentAuthorId}",
                $@"
                SELECT 
                (
                    SELECT TOP(1) AuthorId as FirstAuthorId FROM Authors ORDER BY FirstName
                ) as FirstAuthorId,
                q.PreviousAuthorId,
                q.NextAuthorId,
                (
                    SELECT TOP(1) AuthorId as LastAuthorId FROM Authors ORDER BY FirstName Desc
                ) as LastAuthorId,
                q.RowNumber
                FROM
                (
                    SELECT AuthorId, FirstName,
                    LEAD(AuthorId) OVER(ORDER BY FirstName) AS NextAuthorId,
                    LAG(AuthorId) OVER(ORDER BY FirstName) AS PreviousAuthorId,
                    ROW_NUMBER() OVER(ORDER BY FirstName) AS 'RowNumber'
                    FROM Authors
                ) AS q
                WHERE q.AuthorId = '{currentAuthorId}'
                ORDER BY q.FirstName".Replace(System.Environment.NewLine," "),
                $"SELECT COUNT(AuthorId) as AuthorCount FROM Authors"
            };

            DataSet ds = new DataSet();
            ds = DataAccess.GetData(sqlStatements);

            if (Convert.ToInt32(ds.Tables[2].Rows[0]["AuthorCount"]) == 0)
            {
                MessageBox.Show("No records in the system.");
                btnAdd_Click(null, null);
                return;
            }

            DataRow selectedProduct = ds.Tables[0].Rows[0];

            txtAuthorId.Text = selectedProduct["AuthorId"].ToString();
            txtFirstName.Text = selectedProduct["FirstName"].ToString();
            txtLastName.Text = selectedProduct["LastName"].ToString();
            txtDescription.Text = selectedProduct["Description"].ToString();

            firstAuthorId = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstAuthorId"]);
            previousAuthorId = ds.Tables[1].Rows[0]["PreviousAuthorId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousAuthorId"]) : (int?)null;
            nextAuthorId = ds.Tables[1].Rows[0]["NextAuthorId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextAuthorId"]) : (int?)null;
            lastAuthorId = Convert.ToInt32(ds.Tables[1].Rows[0]["LastAuthorId"]);
            currentRecord = Convert.ToInt32(ds.Tables[1].Rows[0]["RowNumber"]);
            recordCount = Convert.ToInt32(ds.Tables[2].Rows[0]["AuthorCount"]);

            UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from MaintainAuthors");
            NextPreviousButtonManagement();
        }
        #endregion

        #region[Database Management]
        /// <summary>
        /// Begin new Author Add
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UpdateStatusLabelStatus("Adding...");
            UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from MaintainAuthors");

            ClearControls(this.Controls);

            btnUpdate.Text = "Update";
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;

            NavigationState(false);
        }

        /// <summary>
        /// Delete current Author
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from MaintainAuthors");
            try
            {
                DeleteAuthor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Update/Add Author
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from MaintainAuthors");
            try
            {
                txtFirstName.CausesValidation = true;
                txtLastName.CausesValidation = true;
                txtDescription.CausesValidation = true;
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (btnAdd.Enabled == false)
                    {
                        UpdateStatusStripProgress();
                        CreateAuthor();
                    }
                    else
                    {
                        UpdateStatusStripProgress();
                        SaveAuthorChanges();
                    }
                }
                else
                {
                    MessageBox.Show("There are errors. Will not proceed with operation.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Cancel Add new Author
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateStatusLabelStatus(string.Empty);
            btnUpdate.Text = "Update";
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;

            txtFirstName.CausesValidation = false;
            txtLastName.CausesValidation = false;
            txtDescription.CausesValidation = false;

            NavigationState(true);
            LoadAuthorDetails();
        }

        /// <summary>
        /// Add Author Functionality
        /// </summary>
        private void CreateAuthor()
        {
            string sql = $@"
                INSERT INTO [dbo].[Authors]
                    ([FirstName]
                    ,[LastName]
                    ,[Description])
                VALUES
                    (
                        '{txtFirstName.Text.Trim()}',
                        '{txtLastName.Text.Trim()}',
                        '{txtDescription.Text.Trim()}'
                    )
            ";

            int rowsAffected = DataAccess.ExecuteNonQuery(sql);
            if (rowsAffected == 1)
            {
                MessageBox.Show("Author created");
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                LoadFirstAuthor();
                LoadAuthorDetails();
                NavigationState(true);
                btnUpdate.Text = "Update";
            }
            else
            {
                MessageBox.Show("The database reported no rows affected. Record not created.");
            }
        }

        /// <summary>
        /// Update Author Functionality
        /// </summary>
        private void SaveAuthorChanges()
        {
            string sql = $@"
                UPDATE [dbo].[Authors]
                   SET [FirstName] = '{txtFirstName.Text.Trim()}'
                      ,[LastName] = '{txtLastName.Text.Trim()}'
                      ,[Description] = '{txtDescription.Text.Trim()}'
                WHERE AuthorId = '{txtAuthorId.Text.Trim()}'
            ";

            int rowsAddefected = DataAccess.ExecuteNonQuery(sql);
            if (rowsAddefected == 1)
            {
                MessageBox.Show($"Author changes saved.");
            }
            else
            {
                if (rowsAddefected == 0)
                    MessageBox.Show($"Update to AuthorId: {txtAuthorId.Text} was not updated.");
                else
                    MessageBox.Show("Oh oh. Did you forget the where clause?");
            }
        }

        /// <summary>
        /// Delete Current Author
        /// </summary>
        private void DeleteAuthor()
        {
            string sql = $@"DELETE FROM Authors WHERE AuthorId = '{currentAuthorId}'";

            int rowsAffected = DataAccess.ExecuteNonQuery(sql);
            if (rowsAffected == 1)
            {
                MessageBox.Show($"Author was deleted");
                LoadFirstAuthor();
            }
            else if (rowsAffected == 0)
            {
                MessageBox.Show($"AuthorId: {txtAuthorId.Text} does not exist. May have already been deleted.");
            }
            else
            {
                MessageBox.Show($"Oh oh. Did you forget the where clause? Go look at the Authors");
            }
        }
        #endregion

        #region [Utility]
        /// <summary>
        /// Clear Controls
        /// </summary>
        private void ClearControls(Control.ControlCollection controls)
        {
            foreach (Control ctl in controls)
            {
                switch (ctl)
                {
                    case TextBox txt:
                        txt.Clear();
                        break;
                }
            }
        }

        /// <summary>
        /// Text Validation
        /// </summary>
        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string? txtBoxName = txt.Tag.ToString();
            string errMsg = string.Empty;
            bool failedValidation = false;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errMsg = $"{txtBoxName} is required";
                failedValidation = true;
            }

            e.Cancel = failedValidation;
            errProvider.SetError(txt, errMsg);
        }

        /// <summary>
        /// Show Current Form Records
        /// </summary>
        private void btnShowRecords_Click(object sender, EventArgs e)
        {
            UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from MaintainAuthors");
        }

        /// <summary>
        /// Update Status Strip Record
        /// </summary>
        private void UpdateStatusStripRecord(string record1)
        {
            frmMdiParent mdiParent = this.MdiParent as frmMdiParent;

            if (mdiParent != null)
            {
                mdiParent.StatusStripRecord = record1;
            }
        }

        /// <summary>
        /// Update Status Strip Label
        /// </summary>
        private void UpdateStatusLabelStatus(string status1)
        {
            frmMdiParent mdiParent = this.MdiParent as frmMdiParent;

            if (mdiParent != null)
            {
                mdiParent.StatusStripStatus = status1;
            }
        }

        /// <summary>
        /// Update Status Strip Progress bar
        /// </summary>
        private void UpdateStatusStripProgress()
        {
            frmMdiParent mdiParent = this.MdiParent as frmMdiParent;

            if (mdiParent != null)
            {
                UpdateStatusLabelStatus("Processing...");
                mdiParent.StatusStrip.Refresh();

                while (mdiParent.StatusStripProgressBar.Value < mdiParent.StatusStripProgressBar.Maximum)
                {
                    Thread.Sleep(15);
                    mdiParent.StatusStripProgressBar.Value += 1;
                }

                mdiParent.StatusStripProgressBar.Value = 100;
                UpdateStatusLabelStatus("Processed");
                mdiParent.StatusStripProgressBar.Value = 0;
            }
        }
        #endregion

    }
}
