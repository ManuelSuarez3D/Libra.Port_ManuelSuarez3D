using System.ComponentModel;
using System.Data;

namespace LibraryAppProject
{
    public partial class frmMaintainBooks : Form
    {
        public frmMaintainBooks()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load
        /// </summary>
        private void frmMaintainBooks_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAuthors();
                LoadGenres();
                LoadFirstBook();

                cmbAuthor.CausesValidation = false;
                cmbGenre.CausesValidation = false;
                txtTitle.CausesValidation = false;
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
        private void frmMaintainBooks_FormClosed(object sender, FormClosedEventArgs e)
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
        int currentBookId = 0;
        int recordCount = 0;
        int firstBookId = 0;
        int lastBookId = 0;
        int bookCount = 0;
        int? previousBookId;
        int? nextBookId;
        #endregion

        #region [Navigation Helpers]
        /// <summary>
        /// Toggle Next/Previous Button
        /// </summary>
        private void NextPreviousButtonManagement()
        {
            pctPrevious.Enabled = previousBookId != null;
            pctPrevious.Visible = previousBookId != null;
            pctNext.Enabled = nextBookId != null;
            pctNext.Visible = nextBookId != null;
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
                    currentBookId = firstBookId;
                    break;
                case "pctLast":
                    currentBookId = lastBookId;
                    break;
                case "pctPrevious":
                    currentBookId = previousBookId.Value;
                    break;
                case "pctNext":
                    currentBookId = nextBookId.Value;
                    break;
            }

            LoadBookDetails();
        }
        #endregion

        #region [Retrievers]
        /// <summary>
        /// Load First Book
        /// </summary>
        private void LoadFirstBook()
        {
            string sqlGetFirstBookId = $"SELECT TOP (1) BookId FROM Books ORDER BY Title;";
            object bookId = DataAccess.GetValue(sqlGetFirstBookId);

            if (bookId == null)
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

                currentBookId = Convert.ToInt32(bookId);
                firstBookId = currentBookId;

            }
            LoadBookDetails();
        }

        /// <summary>
        /// Load Book Details
        /// </summary>
        private void LoadBookDetails()
        {
            btnCancel.Enabled = false;
            errProvider.Clear();

            string[] sqlStatements = new string[]
            {
                $"SELECT * FROM Books WHERE BookId = {currentBookId}",
                $@"
                SELECT 
                (
                    SELECT TOP(1) BookId as FirstBookId FROM Books ORDER BY Title
                ) as FirstBookId,
                q.PreviousBookId,
                q.NextBookId,
                (
                    SELECT TOP(1) BookId as LastBookId FROM Books ORDER BY Title Desc
                ) as LastBookId,
                q.RowNumber
                FROM
                (
                    SELECT BookId , Title,
                    LEAD(BookId) OVER(ORDER BY Title) AS NextBookId,
                    LAG(BookId) OVER(ORDER BY Title) AS PreviousBookId,
                    ROW_NUMBER() OVER(ORDER BY Title) AS 'RowNumber'
                    FROM Books
                ) AS q
                WHERE q.BookId = {currentBookId}
                ORDER BY q.Title".Replace(System.Environment.NewLine," "),
                $"SELECT COUNT(BookId) as BookCount FROM Books"
            };

            DataSet ds = new DataSet();
            ds = DataAccess.GetData(sqlStatements);

            if (Convert.ToInt32(ds.Tables[2].Rows[0]["BookCount"]) == 0)
            {
                MessageBox.Show("No products in the system.");
                btnAdd_Click(null, null);
                return;
            }

            DataRow selectedProduct = ds.Tables[0].Rows[0];

            txtBookId.Text = selectedProduct["BookId"].ToString();
            cmbAuthor.SelectedValue = selectedProduct["AuthorId"];
            cmbGenre.SelectedValue = selectedProduct["GenreId"];
            txtTitle.Text = selectedProduct["Title"].ToString();
            txtDescription.Text = selectedProduct["Description"].ToString();

            firstBookId = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstBookId"]);
            previousBookId = ds.Tables[1].Rows[0]["PreviousBookId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousBookId"]) : (int?)null;
            nextBookId = ds.Tables[1].Rows[0]["NextBookId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextBookId"]) : (int?)null;
            lastBookId = Convert.ToInt32(ds.Tables[1].Rows[0]["LastBookId"]);
            currentRecord = Convert.ToInt32(ds.Tables[1].Rows[0]["RowNumber"]);
            recordCount = Convert.ToInt32(ds.Tables[2].Rows[0]["BookCount"]);

            UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from MaintainBooks");
            NextPreviousButtonManagement();
        }

        /// <summary>
        /// Load Authors
        /// </summary>
        private void LoadAuthors()
        {
            string sqlAuthors = "SELECT AuthorId, FirstName + ' ' + LastName AS FullName FROM Authors ORDER BY FullName";
            UIUtilities.BindComboBox(cmbAuthor, DataAccess.GetData(sqlAuthors), "FullName", "AuthorId");
        }

        /// <summary>
        /// Load Genres
        /// </summary>
        private void LoadGenres()
        {
            string sqlGenres = "SELECT GenreId, Name FROM Genres ORDER BY Name";
            UIUtilities.BindComboBox(cmbGenre, DataAccess.GetData(sqlGenres), "Name", "GenreId");
        }
        #endregion

        #region[Database Management]
        /// <summary>
        /// Begin new Book Add
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CanAddBook())
            {
                UpdateStatusLabelStatus("Adding...");
                UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from MaintainBooks");

                ClearControls(this.Controls);

                LoadAuthors();
                LoadGenres();

                btnUpdate.Text = "Update";
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnCancel.Enabled = true;

                NavigationState(false);
            }
            else
            {
                MessageBox.Show("You've entered the maximum amount of books for this session, please reconnect.");
            }
        }

        /// <summary>
        /// Delete current Book
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from MaintainBooks");
            try
            {
                DeleteBook();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Update/Add Book
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from MaintainBooks");
            try
            {
                cmbAuthor.CausesValidation = true;
                cmbGenre.CausesValidation = true;
                txtTitle.CausesValidation = true;
                txtDescription.CausesValidation = true;

                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (btnAdd.Enabled == false)
                    {
                        UpdateStatusStripProgress();
                        CreateBook();
                    }
                    else
                    {
                        UpdateStatusStripProgress();
                        SaveBookChanges();
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
        /// Cancel Add new Book
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateStatusLabelStatus(string.Empty);
            btnUpdate.Text = "Update";
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;

            cmbAuthor.CausesValidation = false;
            cmbGenre.CausesValidation = false;
            txtTitle.CausesValidation = false;
            txtDescription.CausesValidation = false;

            NavigationState(true);
            LoadBookDetails();
        }

        /// <summary>
        /// Add Book Functionality
        /// </summary>
        private void CreateBook()
        {
            string sql = $@"
                INSERT INTO [dbo].[Books]
                    ([Title]
                    ,[Description]
                    ,[AuthorId]
                    ,[GenreId])
                VALUES
                    (
                        '{txtTitle.Text.Trim()}',
                        '{txtDescription.Text.Trim()}',
                        '{cmbAuthor.SelectedValue}',
                        '{cmbGenre.SelectedValue}'
                    )
            ";

            int rowsAffected = DataAccess.ExecuteNonQuery(sql);
            if (rowsAffected == 1)
            {
                MessageBox.Show("Book created");
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                LoadFirstBook();
                LoadBookDetails();
                NavigationState(true);
                btnUpdate.Text = "Update";
            }
            else
            {
                MessageBox.Show("The database reported no rows affected. Record not created.");
            }
            bookCount++;
        }

        /// <summary>
        /// Update Book Functionality
        /// </summary>
        private void SaveBookChanges()
        {
            string sql = $@"
                UPDATE [dbo].[Books]
                   SET [Title] = '{txtTitle.Text.Trim()}'
                      ,[Description] = '{txtDescription.Text.Trim()}'
                      ,[AuthorId] = {cmbAuthor.SelectedValue}
                      ,[GenreId] = {cmbGenre.SelectedValue}
                WHERE BookId = '{txtBookId.Text.Trim()}'
            ";

            int rowsAddefected = DataAccess.ExecuteNonQuery(sql);
            if (rowsAddefected == 1)
            {
                MessageBox.Show($"Book changes saved.");
            }
            else
            {
                if (rowsAddefected == 0)
                    MessageBox.Show($"Update to BookId: {txtBookId.Text} was not updated.");
                else
                    MessageBox.Show("Oh oh. Did you forget the where clause?");
            }

        }

        /// <summary>
        /// Delete Current Book
        /// </summary>
        private void DeleteBook()
        {
            string sql = $@"DELETE FROM Books WHERE BookId = '{currentBookId}'";

            int rowsAffected = DataAccess.ExecuteNonQuery(sql);
            if (rowsAffected == 1)
            {
                MessageBox.Show($"Book was deleted");
                LoadFirstBook();
            }
            else if (rowsAffected == 0)
            {
                MessageBox.Show($"BookId: {txtBookId.Text} does not exist. May have already been deleted.");
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
            UpdateStatusStripRecord($"Displaying record {currentRecord} of {recordCount}, from MaintainBooks");
        }

        /// <summary>
        /// Admin Book Functionality
        /// </summary>
        private bool CanAddBook()
        {
            bool result = false;
            int bookCheck = frmMdiParent.BookCount;
            bool adminCheck = frmMdiParent.Admin;

            if (bookCount < bookCheck || adminCheck)
            {
                result = true;
            }

            return result;
        }
        #endregion


    }
}
