using System.ComponentModel;
using System.Data;

namespace LibraryAppProject
{
    public partial class frmMaintainGenres : Form
    {
        public frmMaintainGenres()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load
        /// </summary>
        private void frmMaintainGenres_Load(object sender, EventArgs e)
        {
            try
            {
                LoadFirstGenre();
                txtName.CausesValidation = false;
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
        private void frmMaintainGenres_FormClosed(object sender, FormClosedEventArgs e)
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
        int currentGenreId = 0;
        int recordCount = 0;
        int firstGenreId = 0;
        int lastGenreId = 0;
        int? previousGenreId;
        int? nextGenreId;
        #endregion

        #region [Navigation Helpers]
        /// <summary>
        /// Toggle Next/Previous Button
        /// </summary>
        private void NextPreviousButtonManagement()
        {
            pctPrevious.Enabled = previousGenreId != null;
            pctPrevious.Visible = previousGenreId != null;
            pctNext.Enabled = nextGenreId != null;
            pctNext.Visible = nextGenreId != null;
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
                    currentGenreId = firstGenreId;
                    break;
                case "pctLast":
                    currentGenreId = lastGenreId;
                    break;
                case "pctPrevious":
                    currentGenreId = previousGenreId.Value;
                    break;
                case "pctNext":
                    currentGenreId = nextGenreId.Value;
                    break;
            }

            LoadGenreDetails();
        }
        #endregion

        #region [Retrievers]
        /// <summary>
        /// Load First Genre
        /// </summary>
        private void LoadFirstGenre()
        {
            string sqlGetFirstGenreId = $"SELECT TOP (1) GenreId FROM Genres ORDER BY Name;";
            object genreId = DataAccess.GetValue(sqlGetFirstGenreId);

            if (genreId == null)
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

                currentGenreId = Convert.ToInt32(genreId);
                firstGenreId = currentGenreId;
            }
            LoadGenreDetails();
        }

        /// <summary>
        /// Load Genre Details
        /// </summary>
        private void LoadGenreDetails()
        {
            btnCancel.Enabled = false;
            errProvider.Clear();

            string[] sqlStatements = new string[]
            {
                $"SELECT * FROM Genres WHERE GenreId = {currentGenreId}",
                $@"
                SELECT 
                (
                    SELECT TOP(1) GenreId as FirstGenreId FROM Genres ORDER BY Name
                ) as FirstGenreId,
                q.PreviousGenreId,
                q.NextGenreId,
                (
                    SELECT TOP(1) GenreId as LastGenreId FROM Genres ORDER BY Name Desc
                ) as LastGenreId,
                q.RowNumber
                FROM
                (
                    SELECT GenreId, Name,
                    LEAD(GenreId) OVER(ORDER BY Name) AS NextGenreId,
                    LAG(GenreId) OVER(ORDER BY Name) AS PreviousGenreId,
                    ROW_NUMBER() OVER(ORDER BY Name) AS 'RowNumber'
                    FROM Genres
                ) AS q
                WHERE q.GenreId = '{currentGenreId}'
                ORDER BY q.Name".Replace(System.Environment.NewLine," "),
                $"SELECT COUNT(GenreId) as GenreCount FROM Genres"
            };

            DataSet ds = new DataSet();
            ds = DataAccess.GetData(sqlStatements);

            if (Convert.ToInt32(ds.Tables[2].Rows[0]["GenreCount"]) == 0)
            {
                MessageBox.Show("No records in the system.");
                btnAdd_Click(null, null);
                return;
            }

            DataRow selectedProduct = ds.Tables[0].Rows[0];

            txtGenreId.Text = selectedProduct["GenreId"].ToString();
            txtName.Text = selectedProduct["Name"].ToString();
            txtDescription.Text = selectedProduct["Description"].ToString();

            firstGenreId = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstGenreId"]);
            previousGenreId = ds.Tables[1].Rows[0]["PreviousGenreId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousGenreId"]) : (int?)null;
            nextGenreId = ds.Tables[1].Rows[0]["NextGenreId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextGenreId"]) : (int?)null;
            lastGenreId = Convert.ToInt32(ds.Tables[1].Rows[0]["LastGenreId"]);
            currentRecord = Convert.ToInt32(ds.Tables[1].Rows[0]["RowNumber"]);
            recordCount = Convert.ToInt32(ds.Tables[2].Rows[0]["GenreCount"]);

            UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from MaintainGenres");
            NextPreviousButtonManagement();
        }
        #endregion

        #region[Database Management]
        /// <summary>
        /// Begin new Genre Add
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UpdateStatusLabelStatus("Adding...");
            UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from MaintainGenres");

            ClearControls(this.Controls);

            btnUpdate.Text = "Update";
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;

            NavigationState(false);
        }

        /// <summary>
        /// Delete current Genre
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from MaintainGenres");
            try
            {
                DeleteGenre();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Update/Add Genre
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from MaintainGenres");
            try
            {
                txtName.CausesValidation = true;
                txtDescription.CausesValidation = true;

                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (btnAdd.Enabled == false)
                    {
                        UpdateStatusStripProgress();
                        CreateGenre();
                    }
                    else
                    {
                        UpdateStatusStripProgress();
                        SaveGenreChanges();
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
        /// Cancel Add new Genre
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateStatusLabelStatus(string.Empty);
            btnUpdate.Text = "Update";
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;

            txtName.CausesValidation = false;
            txtDescription.CausesValidation = false;

            NavigationState(true);
            LoadGenreDetails();
        }

        /// <summary>
        /// Add Genre Functionality
        /// </summary>
        private void CreateGenre()
        {
            string sql = $@"
                INSERT INTO [dbo].[Genres]
                    ([Name]
                    ,[Description])
                VALUES
                    (
                        '{txtName.Text.Trim()}',
                        '{txtDescription.Text.Trim()}'
                    )
            ";

            int rowsAffected = DataAccess.ExecuteNonQuery(sql);
            if (rowsAffected == 1)
            {
                MessageBox.Show("Genres created");
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                LoadFirstGenre();
                LoadGenreDetails();
                NavigationState(true);
                btnUpdate.Text = "Update";
            }
            else
            {
                MessageBox.Show("The database reported no rows affected. Record not created.");
            }
        }

        /// <summary>
        /// Update Genre Functionality
        /// </summary>
        private void SaveGenreChanges()
        {
            string sql = $@"
                UPDATE [dbo].[Genres]
                   SET [Name] = '{txtName.Text.Trim()}'
                      ,[Description] = '{txtDescription.Text.Trim()}'
                WHERE GenreId = '{txtGenreId.Text.Trim()}'
            ";

            int rowsAddefected = DataAccess.ExecuteNonQuery(sql);
            if (rowsAddefected == 1)
            {
                MessageBox.Show($"Genre changes saved.");
            }
            else
            {
                if (rowsAddefected == 0)
                    MessageBox.Show($"Update to GenreId: {txtGenreId.Text} was not updated.");
                else
                    MessageBox.Show("Oh oh. Did you forget the where clause?");
            }

        }

        /// <summary>
        /// Delete Current Genre
        /// </summary>
        private void DeleteGenre()
        {
            string sql = $@"DELETE FROM Genres WHERE GenreId = '{currentGenreId}'";

            int rowsAffected = DataAccess.ExecuteNonQuery(sql);
            if (rowsAffected == 1)
            {
                MessageBox.Show($"Genre was deleted");
                LoadFirstGenre();
            }
            else if (rowsAffected == 0)
            {
                MessageBox.Show($"GenreId: {txtGenreId.Text} does not exist. May have already been deleted.");
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

        /// <summary>
        /// Show Current Form Records
        /// </summary>
        private void btnShowRecords_Click(object sender, EventArgs e)
        {
            UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from MaintainGenres");
        }
        #endregion

    }
}
