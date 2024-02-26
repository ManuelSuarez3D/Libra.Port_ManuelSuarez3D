namespace LibraryAppProject
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblUser = new Label();
            txtUsername = new TextBox();
            chkPassword = new CheckBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnClear = new Button();
            pctbIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctbIcon).BeginInit();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(68, 55);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(40, 19);
            lblUser.TabIndex = 0;
            lblUser.Text = "User:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(68, 73);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(224, 23);
            txtUsername.TabIndex = 1;
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.BackColor = Color.Transparent;
            chkPassword.Location = new Point(68, 197);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new Size(161, 19);
            chkPassword.TabIndex = 2;
            chkPassword.Text = "Toggle Password Visibility";
            chkPassword.UseVisualStyleBackColor = false;
            chkPassword.CheckedChanged += chkPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(68, 158);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(89, 33);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(68, 117);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(224, 23);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(68, 99);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 19);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(163, 158);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(89, 33);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // pctbIcon
            // 
            pctbIcon.BackColor = Color.Transparent;
            pctbIcon.BackgroundImageLayout = ImageLayout.Stretch;
            pctbIcon.Image = (Image)resources.GetObject("pctbIcon.Image");
            pctbIcon.ImageLocation = "";
            pctbIcon.Location = new Point(336, 64);
            pctbIcon.Name = "pctbIcon";
            pctbIcon.Size = new Size(123, 126);
            pctbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbIcon.TabIndex = 7;
            pctbIcon.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(538, 263);
            Controls.Add(pctbIcon);
            Controls.Add(btnClear);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(btnLogin);
            Controls.Add(chkPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            Text = "Libra.Port - Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pctbIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private TextBox txtUsername;
        private CheckBox chkPassword;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnClear;
        private PictureBox pctbIcon;
    }
}