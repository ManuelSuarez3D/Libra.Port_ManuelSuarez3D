
namespace LibraryAppProject
{
    public partial class frmMdiParent : Form
    {
        /// <summary>
        /// Admin Book Counter
        /// </summary>
        #region[BusinessRule]
        private const int MAX_BOOK_EDIT = 3;
        public static int BookCount { get { return MAX_BOOK_EDIT; } }
        #endregion

        /// <summary>
        /// User/Admin Variable
        /// </summary>
        #region[UserInfo]
        public static string User { get; set; }
        public static bool Admin { get; set; }
        #endregion

        /// <summary>
        /// Status Strips
        /// </summary>
        #region[StatusStripInfo]
        public string StatusStripRecord
        {
            get { return tsRecord.Text; }
            set { tsRecord.Text = value; }
        }
        public string StatusStripStatus
        {
            get { return tsStatus.Text; }
            set { tsStatus.Text = value; }
        }
        public StatusStrip StatusStrip
        {
            get { return statusStrip; }
        }
        public ToolStripProgressBar StatusStripProgressBar
        {
            get { return tsProgress; }
        }
        #endregion

        public frmMdiParent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load
        /// </summary>
        private void frmMdiParent_Load(object sender, EventArgs e)
        {
            frmLogin f = new();

            tsRecord.Text = string.Empty;
            tsStatus.Text = string.Empty;

            f.StartPosition = FormStartPosition.CenterScreen;

            DialogResult result = f.ShowDialog();

            if (result == DialogResult.OK)
            {
                UserAdmin();
            }
            else if (result == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Admin Functionality
        /// </summary>
        private bool UserAdmin()
        {
            try
            {
                string sql = $"SELECT IsAdmin FROM Users WHERE Username = '{User}'";

                object returnValue = DataAccess.GetValue(sql);
                bool boolValue = Convert.ToBoolean(returnValue);

                if (boolValue)
                {
                    Admin = boolValue;
                }
                else
                {
                    Admin = boolValue;
                }
                return boolValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Form Browsing
        /// </summary>
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = null;
            ToolStripMenuItem m = (ToolStripMenuItem)sender;

            tsProgress.Value = 0;
            tsStatus.Text = string.Empty;
            tsRecord.Text = string.Empty;

            switch (m.Tag)
            {
                case "MaintainBooks":
                    childForm = new frmMaintainBooks();
                    break;
                case "MaintainAuthors":
                    childForm = new frmMaintainAuthors();
                    break;
                case "MaintainGenres":
                    childForm = new frmMaintainGenres();
                    break;
                case "BrowseGenres":
                    childForm = new frmBrowseGenres();
                    break;
                case "BrowseAuthors":
                    childForm = new frmBrowseAuthors();
                    break;
                case "About":
                    childForm = new frmAbout();
                    break;
            }

            if (childForm != null)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == childForm.GetType())
                    {
                        f.Activate();
                        return;
                    }
                }

                childForm.MdiParent = this;
                childForm.Show();
            }
        }

        /// <summary>
        /// Tool Strip
        /// </summary>
        private void ShowToolStripForm(object sender, EventArgs e)
        {
            Form childForm = null;
            ToolStripButton m = (ToolStripButton)sender;

            switch (m.Tag)
            {
                case "About":
                    childForm = new frmAbout();
                    break;
            }
            if (childForm != null)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == childForm.GetType())
                    {
                        f.Activate();
                        return;
                    }
                }
                childForm.MdiParent = this;
                childForm.Show();
            }
        }

        /// <summary>
        /// Tool Strip Logout Click
        /// </summary>
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMdiParent f = new();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            f.FormClosed += new FormClosedEventHandler(mdiClose);
        }

        /// <summary>
        /// Form Close
        /// </summary>
        private void mdiClose(object? sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }


}
