
namespace LibraryAppProject
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load
        /// </summary>
        private void frmSplash_Load(object sender, EventArgs e)
        {
            lblAppVersion.Text = Application.ProductVersion;
        }

        /// <summary>
        /// Timer Count
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (prgLoading.Value < 15)
            {
                prgLoading.Increment(1);
            }
            else
            {
                this.Hide();
                timer.Enabled = false;
                frmMdiParent f = new();
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
                f.FormClosed += new FormClosedEventHandler(mdiClose);
            }
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
