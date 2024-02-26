using System.ComponentModel;
using System.Data;

namespace LibraryAppProject
{
    public partial class frmBrowseGenres : Form
    {
        public frmBrowseGenres()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load
        /// </summary>
        private void frmBrowseGenres_Load(object sender, EventArgs e)
        {
            try
            {
                LoadGenres();
                cmbGenres.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Form Close
        /// </summary>
        private void frmBrowseGenres_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMdiParent mdiParent = this.MdiParent as frmMdiParent;

            if (mdiParent != null)
            {
                mdiParent.StatusStripProgressBar.Value = 0;
            }
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

        #region[Retrievers]
        /// <summary>
        /// Load All Genres
        /// </summary>
        private void LoadGenres()
        {
            string sqlGenres = "SELECT GenreId, Name FROM Genres ORDER BY Name";
            UIUtilities.BindComboBox(cmbGenres, DataAccess.GetData(sqlGenres), "Name", "GenreId");
        }

        /// <summary>
        /// Load Genre Details
        /// </summary>
        private void LoadGenreDetails()
        {
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
                return;
            }

            DataRow selectedProduct = ds.Tables[0].Rows[0];

            txtDescription.Text = selectedProduct["Description"].ToString();

            firstGenreId = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstGenreId"]);
            previousGenreId = ds.Tables[1].Rows[0]["PreviousGenreId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousGenreId"]) : (int?)null;
            nextGenreId = ds.Tables[1].Rows[0]["NextGenreId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextGenreId"]) : (int?)null;
            lastGenreId = Convert.ToInt32(ds.Tables[1].Rows[0]["LastGenreId"]);
            currentRecord = Convert.ToInt32(ds.Tables[1].Rows[0]["RowNumber"]);
            recordCount = Convert.ToInt32(ds.Tables[2].Rows[0]["GenreCount"]);

            UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from BrowseGenres");
            LoadAvailableBooks();
        }

        /// <summary>
        /// Load Available Books
        /// </summary>
        private void LoadAvailableBooks()
        {
            dgvGenres.AutoGenerateColumns = true;

            string[] sqlStatements = new string[]
            {
            $@"
                SELECT
                    Books.Title AS BookTitle,
                    Authors.FirstName + ' ' + Authors.LastName AS AuthorName
                FROM
                    Books
                    INNER JOIN Genres ON Books.GenreId = Genres.GenreId
                    INNER JOIN Authors ON Books.AuthorId = Authors.AuthorId
                WHERE
                    Books.GenreId = {currentGenreId};"
            };

            DataSet ds = DataAccess.GetData(sqlStatements);
            dgvGenres.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// Search Click
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                cmbGenres.CausesValidation = true;
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    UpdateStatusStripProgress(0);
                    currentGenreId = Convert.ToInt32(cmbGenres.SelectedValue);
                    LoadGenreDetails();
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
            UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from BrowseGenres");
        }
        #endregion

    }
}
