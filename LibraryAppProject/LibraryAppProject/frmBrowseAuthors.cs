using System.ComponentModel;
using System.Data;

namespace LibraryAppProject
{
    public partial class frmBrowseAuthors : Form
    {
        public frmBrowseAuthors()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Form Load
        /// </summary>
        private void frmBrowseAuthors_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAuthors();
                cmbAuthors.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Form Close
        /// </summary>
        private void frmBrowseAuthors_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMdiParent mdiParent = this.MdiParent as frmMdiParent;

            if (mdiParent != null)
            {
                mdiParent.StatusStripProgressBar.Value = 0;
            }
        }
        
        #region[Tracker]
        int currentRecord = 0;
        int currentAuthorId = 0;
        int recordCount = 0;
        int firstAuthorId = 0;
        int lastAuthorId = 0;
        int? previousAuthorId;
        int? nextAuthorId;
        #endregion

        #region[Retrievers]

        /// <summary>
        /// Load All Authors
        /// </summary>
        private void LoadAuthors()
        {
            string sqlAuthors = "SELECT AuthorId, FirstName + ' ' + LastName AS FullName FROM Authors ORDER BY FullName";
            UIUtilities.BindComboBox(cmbAuthors, DataAccess.GetData(sqlAuthors), "FullName", "AuthorId");
        }

        /// <summary>
        /// Load All D
        /// </summary>
        private void LoadAuthorDetails()
        {
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
                return;
            }

            DataRow selectedProduct = ds.Tables[0].Rows[0];

            txtDescription.Text = selectedProduct["Description"].ToString();

            firstAuthorId = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstAuthorId"]);
            previousAuthorId = ds.Tables[1].Rows[0]["PreviousAuthorId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousAuthorId"]) : (int?)null;
            nextAuthorId = ds.Tables[1].Rows[0]["NextAuthorId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextAuthorId"]) : (int?)null;
            lastAuthorId = Convert.ToInt32(ds.Tables[1].Rows[0]["LastAuthorId"]);
            currentRecord = Convert.ToInt32(ds.Tables[1].Rows[0]["RowNumber"]);
            recordCount = Convert.ToInt32(ds.Tables[2].Rows[0]["AuthorCount"]);

            UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from BrowseAuthors");
            LoadAvailableBooks();
        }

        /// <summary>
        /// Load Available Books
        /// </summary>
        private void LoadAvailableBooks()
        {
            dgvAuthors.AutoGenerateColumns = true;

            string[] sqlStatements = new string[]
            {
            $@"
                SELECT
                    Books.Title AS BookTitle,
                    Genres.Name AS Genre

                FROM
                    Books
                    INNER JOIN Genres ON Books.GenreId = Genres.GenreId
                    INNER JOIN Authors ON Books.AuthorId = Authors.AuthorId
                WHERE
                    Authors.AuthorId = {currentAuthorId};"
            };

            DataSet ds = DataAccess.GetData(sqlStatements);
            dgvAuthors.DataSource = ds.Tables[0];

        }

        /// <summary>
        /// Search Click
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                cmbAuthors.CausesValidation = true;
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    UpdateStatusStripProgress(0);
                    currentAuthorId = Convert.ToInt32(cmbAuthors.SelectedValue);
                    LoadAuthorDetails();
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
        #endregion

        #region[Utility]
        /// <summary>
        /// Combobox Validation
        /// </summary>
        private void cmb_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            string errMsg = string.Empty;
            bool failedValidation = false;

            if (cmb.SelectedIndex == -1 || String.IsNullOrEmpty(cmb.SelectedValue.ToString()))
            {
                errMsg = $"{cmb.Tag} is required";
                failedValidation = true;
            }

            e.Cancel = failedValidation;
            errProvider.SetError(cmb, errMsg);
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
        private void UpdateStatusStripProgress(int progress1)
        {
            frmMdiParent mdiParent = this.MdiParent as frmMdiParent;

            if (mdiParent != null)
            {
                UpdateStatusLabelStatus("Processing...");
                mdiParent.StatusStripProgressBar.Value = 0;
                mdiParent.StatusStrip.Refresh();

                while (mdiParent.StatusStripProgressBar.Value < mdiParent.StatusStripProgressBar.Maximum)
                {
                    Thread.Sleep(15);
                    mdiParent.StatusStripProgressBar.Value += 1;
                }

                mdiParent.StatusStripProgressBar.Value = 100;
                UpdateStatusLabelStatus("Processed");
            }
        }

        /// <summary>
        /// Show Current Form Records
        /// </summary>
        private void btnShowRecords_Click(object sender, EventArgs e)
        {
            UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from BrowseAuthors");
        }
        #endregion

    }
}
