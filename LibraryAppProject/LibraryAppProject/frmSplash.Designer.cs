namespace LibraryAppProject
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            lblAppName = new Label();
            lblAppVersion = new Label();
            lblConnecting = new Label();
            timer = new System.Windows.Forms.Timer(components);
            prgLoading = new ProgressBar();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = Color.Transparent;
            lblAppName.Font = new Font("Modern No. 20", 35F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblAppName.ForeColor = Color.MediumAquamarine;
            lblAppName.Location = new Point(193, 133);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(234, 48);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Libra.Port";
            // 
            // lblAppVersion
            // 
            lblAppVersion.AutoSize = true;
            lblAppVersion.BackColor = Color.Transparent;
            lblAppVersion.Location = new Point(546, 286);
            lblAppVersion.Name = "lblAppVersion";
            lblAppVersion.Size = new Size(75, 15);
            lblAppVersion.TabIndex = 1;
            lblAppVersion.Text = "[AppVersion]";
            // 
            // lblConnecting
            // 
            lblConnecting.AutoSize = true;
            lblConnecting.BackColor = Color.Transparent;
            lblConnecting.Location = new Point(274, 181);
            lblConnecting.Name = "lblConnecting";
            lblConnecting.Size = new Size(78, 15);
            lblConnecting.TabIndex = 2;
            lblConnecting.Text = "Connecting...";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            // 
            // prgLoading
            // 
            prgLoading.Location = new Point(193, 204);
            prgLoading.Maximum = 15;
            prgLoading.Name = "prgLoading";
            prgLoading.Size = new Size(234, 10);
            prgLoading.TabIndex = 3;
            // 
            // frmSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(630, 310);
            Controls.Add(lblConnecting);
            Controls.Add(lblAppVersion);
            Controls.Add(lblAppName);
            Controls.Add(prgLoading);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSplash";
            Load += frmSplash_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label lblAppName;
        private Label lblAppVersion;
        private Label lblConnecting;
        private ProgressBar prgLoading;
        private System.Windows.Forms.Timer timer;
    }
}