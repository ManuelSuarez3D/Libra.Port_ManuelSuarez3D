namespace LibraryAppProject
{
    partial class frmBrowseGenres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowseGenres));
            cmbGenres = new ComboBox();
            dgvGenres = new DataGridView();
            lbl = new Label();
            lblPurpose = new Label();
            label2 = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            btnSearch = new Button();
            errProvider = new ErrorProvider(components);
            btnShowRecords = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGenres).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // cmbGenres
            // 
            cmbGenres.FormattingEnabled = true;
            cmbGenres.Location = new Point(100, 175);
            cmbGenres.Name = "cmbGenres";
            cmbGenres.Size = new Size(216, 23);
            cmbGenres.TabIndex = 74;
            cmbGenres.Tag = "Genre";
            cmbGenres.Validating += cmb_Validating;
            // 
            // dgvGenres
            // 
            dgvGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGenres.Location = new Point(100, 320);
            dgvGenres.Name = "dgvGenres";
            dgvGenres.RowTemplate.Height = 25;
            dgvGenres.Size = new Size(458, 128);
            dgvGenres.TabIndex = 75;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.Location = new Point(100, 157);
            lbl.Name = "lbl";
            lbl.Size = new Size(41, 15);
            lbl.TabIndex = 76;
            lbl.Text = "Genre:";
            // 
            // lblPurpose
            // 
            lblPurpose.AutoSize = true;
            lblPurpose.BackColor = Color.Transparent;
            lblPurpose.Font = new Font("Modern No. 20", 35.2499962F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblPurpose.ForeColor = Color.MediumAquamarine;
            lblPurpose.Location = new Point(100, 88);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(312, 48);
            lblPurpose.TabIndex = 77;
            lblPurpose.Text = "Browse Genres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(100, 302);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 78;
            label2.Text = "Available Books";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(100, 224);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(458, 64);
            txtDescription.TabIndex = 79;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Location = new Point(100, 206);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 80;
            lblDescription.Text = "Description";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(356, 175);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 81;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // errProvider
            // 
            errProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errProvider.ContainerControl = this;
            // 
            // btnShowRecords
            // 
            btnShowRecords.Location = new Point(437, 175);
            btnShowRecords.Name = "btnShowRecords";
            btnShowRecords.Size = new Size(91, 23);
            btnShowRecords.TabIndex = 88;
            btnShowRecords.Text = "Show Records";
            btnShowRecords.UseVisualStyleBackColor = true;
            btnShowRecords.Click += btnShowRecords_Click;
            // 
            // frmBrowseGenres
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
            Controls.Add(lbl);
            Controls.Add(dgvGenres);
            Controls.Add(cmbGenres);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBrowseGenres";
            Text = "Browse Genres";
            FormClosed += frmBrowseGenres_FormClosed;
            Load += frmBrowseGenres_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGenres).EndInit();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbGenres;
        private DataGridView dgvGenres;
        private Label lbl;
        private Label lblPurpose;
        private Label label2;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btnSearch;
        private ErrorProvider errProvider;
        private Button btnShowRecords;
    }
}