using System.Data;

namespace LibraryAppProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load
        /// </summary>
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Password Visiblity
        /// </summary>
        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkPassword.Checked;
        }

        /// <summary>
        /// Login Functionality
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string[] sqlStatements = new string[]
            {
                $"SELECT * FROM Users WHERE Username = '{txtUsername.Text.Trim()}'",
                $"SELECT COUNT(UserId) as UserCount FROM Users WHERE Username = '{txtUsername.Text.Trim()}' AND Password = '{txtPassword.Text.Trim()}'"
            };

            DataSet ds = DataAccess.GetData(sqlStatements);

            if (Convert.ToInt32(ds.Tables[0].Rows.Count) == 0 || Convert.ToInt32(ds.Tables[1].Rows[0]["UserCount"]) == 0)
            {
                MessageBox.Show("Insert correct username and password.");
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                frmMdiParent.User = txtUsername.Text.Trim();

                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Clear Fields
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

    }

}