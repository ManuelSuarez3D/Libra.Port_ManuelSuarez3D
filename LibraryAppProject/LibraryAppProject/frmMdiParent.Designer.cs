namespace LibraryAppProject
{
    partial class frmMdiParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMdiParent));
            statusStrip = new StatusStrip();
            tsStatus = new ToolStripStatusLabel();
            tsRecord = new ToolStripStatusLabel();
            tsProgress = new ToolStripProgressBar();
            toolTip = new ToolTip(components);
            msMainStrip = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            addBooksToolStripMenuItem = new ToolStripMenuItem();
            booksToolStripMenuItem = new ToolStripMenuItem();
            genresToolStripMenuItem1 = new ToolStripMenuItem();
            authorsToolStripMenuItem1 = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            authorsToolStripMenuItem = new ToolStripMenuItem();
            genresToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            sToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            timer1 = new System.Windows.Forms.Timer(components);
            logoutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip.SuspendLayout();
            msMainStrip.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { tsStatus, tsRecord, tsProgress });
            statusStrip.Location = new Point(0, 627);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(789, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // tsStatus
            // 
            tsStatus.Name = "tsStatus";
            tsStatus.Size = new Size(47, 17);
            tsStatus.Text = "[Status]";
            // 
            // tsRecord
            // 
            tsRecord.Name = "tsRecord";
            tsRecord.Size = new Size(52, 17);
            tsRecord.Text = "[Record]";
            // 
            // tsProgress
            // 
            tsProgress.Name = "tsProgress";
            tsProgress.Size = new Size(100, 16);
            // 
            // msMainStrip
            // 
            msMainStrip.BackColor = SystemColors.ControlLight;
            msMainStrip.ImageScalingSize = new Size(30, 30);
            msMainStrip.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, sToolStripMenuItem });
            msMainStrip.LayoutStyle = ToolStripLayoutStyle.Flow;
            msMainStrip.Location = new Point(0, 0);
            msMainStrip.Name = "msMainStrip";
            msMainStrip.Size = new Size(789, 23);
            msMainStrip.TabIndex = 74;
            msMainStrip.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, addBooksToolStripMenuItem, adminToolStripMenuItem, toolStripSeparator3 });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(50, 19);
            settingsToolStripMenuItem.Text = "&Menu";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(191, 6);
            // 
            // addBooksToolStripMenuItem
            // 
            addBooksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { booksToolStripMenuItem, genresToolStripMenuItem1, authorsToolStripMenuItem1 });
            addBooksToolStripMenuItem.Image = (Image)resources.GetObject("addBooksToolStripMenuItem.Image");
            addBooksToolStripMenuItem.Name = "addBooksToolStripMenuItem";
            addBooksToolStripMenuItem.Size = new Size(194, 36);
            addBooksToolStripMenuItem.Tag = "";
            addBooksToolStripMenuItem.Text = "Manage";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(116, 22);
            booksToolStripMenuItem.Tag = "MaintainBooks";
            booksToolStripMenuItem.Text = "Books";
            booksToolStripMenuItem.Click += ShowNewForm;
            // 
            // genresToolStripMenuItem1
            // 
            genresToolStripMenuItem1.Image = (Image)resources.GetObject("genresToolStripMenuItem1.Image");
            genresToolStripMenuItem1.Name = "genresToolStripMenuItem1";
            genresToolStripMenuItem1.Size = new Size(116, 22);
            genresToolStripMenuItem1.Tag = "MaintainGenres";
            genresToolStripMenuItem1.Text = "Genres";
            genresToolStripMenuItem1.Click += ShowNewForm;
            // 
            // authorsToolStripMenuItem1
            // 
            authorsToolStripMenuItem1.Image = (Image)resources.GetObject("authorsToolStripMenuItem1.Image");
            authorsToolStripMenuItem1.Name = "authorsToolStripMenuItem1";
            authorsToolStripMenuItem1.Size = new Size(116, 22);
            authorsToolStripMenuItem1.Tag = "MaintainAuthors";
            authorsToolStripMenuItem1.Text = "Authors";
            authorsToolStripMenuItem1.Click += ShowNewForm;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { authorsToolStripMenuItem, genresToolStripMenuItem });
            adminToolStripMenuItem.Image = (Image)resources.GetObject("adminToolStripMenuItem.Image");
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(194, 36);
            adminToolStripMenuItem.Text = "Browse";
            // 
            // authorsToolStripMenuItem
            // 
            authorsToolStripMenuItem.Image = (Image)resources.GetObject("authorsToolStripMenuItem.Image");
            authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            authorsToolStripMenuItem.Size = new Size(116, 22);
            authorsToolStripMenuItem.Tag = "BrowseGenres";
            authorsToolStripMenuItem.Text = "Genres";
            authorsToolStripMenuItem.Click += ShowNewForm;
            // 
            // genresToolStripMenuItem
            // 
            genresToolStripMenuItem.Image = (Image)resources.GetObject("genresToolStripMenuItem.Image");
            genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            genresToolStripMenuItem.Size = new Size(116, 22);
            genresToolStripMenuItem.Tag = "BrowseAuthors";
            genresToolStripMenuItem.Text = "Authors";
            genresToolStripMenuItem.Click += ShowNewForm;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(191, 6);
            // 
            // sToolStripMenuItem
            // 
            sToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            sToolStripMenuItem.Name = "sToolStripMenuItem";
            sToolStripMenuItem.Size = new Size(61, 19);
            sToolStripMenuItem.Text = "&Settings";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 23);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(789, 25);
            toolStrip1.TabIndex = 101;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Tag = "About";
            toolStripButton1.Text = "About";
            toolStripButton1.Click += ShowToolStripForm;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Image = (Image)resources.GetObject("logoutToolStripMenuItem.Image");
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(194, 36);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // frmMdiParent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 247);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(789, 649);
            Controls.Add(toolStrip1);
            Controls.Add(msMainStrip);
            Controls.Add(statusStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMdiParent";
            Text = "Libra.Port - Menu";
            Load += frmMdiParent_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            msMainStrip.ResumeLayout(false);
            msMainStrip.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip;
        private ToolStripStatusLabel tsStatus;
        private ToolTip toolTip;
        private MenuStrip msMainStrip;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem addBooksToolStripMenuItem;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem genresToolStripMenuItem1;
        private ToolStripMenuItem authorsToolStripMenuItem1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem authorsToolStripMenuItem;
        private ToolStripMenuItem genresToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private PictureBox pctBooks;
        private PictureBox pctGenres;
        private PictureBox pctAuthors;
        private Label lblAbout;
        private PictureBox pctGenresBrowse;
        private PictureBox pctAuthorsBrowse;
        private PictureBox pctAbout;
        private Label lblManage;
        private Label lblAuthorsBrowse;
        private Label lblGenreBrowse;
        private Label lblGenres;
        private Label lblBooks;
        private Label lblAuthors;
        private Label lblBrowse;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripStatusLabel tsRecord;
        private ToolStripProgressBar tsProgress;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem sToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}



