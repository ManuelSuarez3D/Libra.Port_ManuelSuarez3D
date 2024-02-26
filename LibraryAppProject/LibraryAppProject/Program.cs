namespace LibraryAppProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ApplicationConfiguration.Initialize();
            // Application.Run(new frmAbout());
            // Application.Run(new frmBrowseAuthors());
            // Application.Run(new frmBrowseGenres());
            // Application.Run(new frmLogin());
            // Application.Run(new frmMaintainAuthors());
            // Application.Run(new frmMaintainBooks());
            // Application.Run(new frmMaintainGenres());

            Application.Run(new frmSplash());
            //Application.Run(new frmMdiParent());
        }
    }
}