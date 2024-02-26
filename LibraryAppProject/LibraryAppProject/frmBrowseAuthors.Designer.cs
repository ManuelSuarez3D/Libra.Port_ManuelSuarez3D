namespace LibraryAppProject
{
    partial class frmBrowseAuthors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowseAuthors));
            label2 = new Label();
            lblPurpose = new Label();
            label1 = new Label();
            dgvAuthors = new DataGridView();
            cmbAuthors = new ComboBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnSearch = new Button();
            btnShowRecords = new Button();
            errProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(100, 324);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 83;
            label2.Text = "Available Books";
            // 
            // lblPurpose
            // 
            lblPurpose.AutoSize = true;
            lblPurpose.BackColor = Color.Transparent;
            lblPurpose.Font = new Font("Modern No. 20", 35.2499962F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblPurpose.ForeColor = Color.MediumAquamarine;
            lblPurpose.Location = new Point(100, 94);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(336, 48);
            lblPurpose.TabIndex = 82;
            lblPurpose.Text = "Browse Authors";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(100, 163);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 81;
            label1.Text = "Author:";
            // 
            // dgvAuthors
            // 
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthors.Location = new Point(100, 342);
            dgvAuthors.Name = "dgvAuthors";
            dgvAuthors.RowTemplate.Height = 25;
            dgvAuthors.Size = new Size(458, 112);
            dgvAuthors.TabIndex = 80;
            // 
            // cmbAuthors
            // 
            cmbAuthors.FormattingEnabled = true;
            cmbAuthors.Location = new Point(100, 181);
            cmbAuthors.Name = "cmbAuthors";
            cmbAuthors.Size = new Size(216, 23);
            cmbAuthors.TabIndex = 79;
            cmbAuthors.Tag = "Author";
            cmbAuthors.Validating += cmb_Validating;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Location = new Point(100, 216);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 85;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(100, 234);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(458, 78);
            txtDescription.TabIndex = 84;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(361, 181);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 86;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowRecords
            // 
            btnShowRecords.Location = new Point(442, 181);
            btnShowRecords.Name = "btnShowRecords";
            btnShowRecords.Size = new Size(91, 23);
            btnShowRecords.TabIndex = 87;
            btnShowRecords.Text = "Show Records";
            btnShowRecords.UseVisualStyleBackColor = true;
            btnShowRecords.Click += btnShowRecords_Click;
            // 
            // errProvider
            // 
            errProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errProvider.ContainerControl = this;
            // 
            // frmBrowseAuthors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(659, 548);
            Controls.Add(btnShowRecords);
            Controls.Add(btnSearch);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(lblPurpose);
            Controls.Add(label1);
            Controls.Add(dgvAuthors);
            Controls.Add(cmbAuthors);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBrowseAuthors";
            Text = "Browse Authors";
            FormClosed += frmBrowseAuthors_FormClosed;
            Load += frmBrowseAuthors_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMainStrip;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem addBooksToolStripMenuItem;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem genresToolStripMenuItem1;
        private ToolStripMenuItem authorsToolStripMenuItem1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem authorsToolStripMenuItem;
        private ToolStripMenuItem genresToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private Label label2;
        private Label lblPurpose;
        private Label label1;
        private DataGridView dgvAuthors;
        private ComboBox cmbAuthors;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnSearch;
        private Button btnShowRecords;
        private ErrorProvider errProvider;
    }
}