namespace LibraryAppProject
{
    partial class frmMaintainBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintainBooks));
            btnCancel = new Button();
            btnUpdate = new Button();
            pctbIcon = new PictureBox();
            btnDelete = new Button();
            btnAdd = new Button();
            txtTitle = new TextBox();
            lblDescription = new Label();
            lblTitle = new Label();
            lblPurpose = new Label();
            cmbGenre = new ComboBox();
            lblGenre = new Label();
            lblAuthor = new Label();
            cmbAuthor = new ComboBox();
            pctFirst = new PictureBox();
            pctNext = new PictureBox();
            pctPrevious = new PictureBox();
            pctLast = new PictureBox();
            txtBookId = new TextBox();
            lblId = new Label();
            errProvider = new ErrorProvider(components);
            txtDescription = new TextBox();
            btnShowRecords = new Button();
            ((System.ComponentModel.ISupportInitialize)pctbIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctFirst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPrevious).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctLast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(377, 424);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(89, 33);
            btnCancel.TabIndex = 45;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(282, 424);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(89, 33);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // pctbIcon
            // 
            pctbIcon.BackColor = Color.Transparent;
            pctbIcon.Image = (Image)resources.GetObject("pctbIcon.Image");
            pctbIcon.Location = new Point(413, 204);
            pctbIcon.Name = "pctbIcon";
            pctbIcon.Size = new Size(156, 162);
            pctbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbIcon.TabIndex = 43;
            pctbIcon.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(187, 424);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 33);
            btnDelete.TabIndex = 42;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(92, 424);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 33);
            btnAdd.TabIndex = 41;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtTitle
            // 
            txtTitle.ForeColor = Color.Black;
            txtTitle.Location = new Point(92, 178);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(276, 23);
            txtTitle.TabIndex = 39;
            txtTitle.Tag = "Title";
            txtTitle.Validating += txt_Validating;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Location = new Point(92, 294);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 38;
            lblDescription.Text = "Description:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Location = new Point(92, 160);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 37;
            lblTitle.Text = "Title:";
            // 
            // lblPurpose
            // 
            lblPurpose.AutoSize = true;
            lblPurpose.BackColor = Color.Transparent;
            lblPurpose.Font = new Font("Modern No. 20", 35.2499962F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblPurpose.ForeColor = Color.MediumAquamarine;
            lblPurpose.Location = new Point(167, 80);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(324, 48);
            lblPurpose.TabIndex = 36;
            lblPurpose.Text = "Maintain Book";
            // 
            // cmbGenre
            // 
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.ForeColor = Color.Black;
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(92, 268);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(276, 23);
            cmbGenre.TabIndex = 51;
            cmbGenre.Tag = "Genre";
            cmbGenre.Validating += cmb_Validating;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.BackColor = Color.Transparent;
            lblGenre.Location = new Point(92, 250);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(41, 15);
            lblGenre.TabIndex = 52;
            lblGenre.Text = "Genre:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.BackColor = Color.Transparent;
            lblAuthor.Location = new Point(92, 206);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(47, 15);
            lblAuthor.TabIndex = 54;
            lblAuthor.Text = "Author:";
            // 
            // cmbAuthor
            // 
            cmbAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAuthor.ForeColor = Color.Black;
            cmbAuthor.FormattingEnabled = true;
            cmbAuthor.Location = new Point(92, 224);
            cmbAuthor.Name = "cmbAuthor";
            cmbAuthor.Size = new Size(276, 23);
            cmbAuthor.TabIndex = 53;
            cmbAuthor.Tag = "Author";
            cmbAuthor.Validating += cmb_Validating;
            // 
            // pctFirst
            // 
            pctFirst.BackColor = Color.Transparent;
            pctFirst.Image = (Image)resources.GetObject("pctFirst.Image");
            pctFirst.Location = new Point(187, 141);
            pctFirst.Name = "pctFirst";
            pctFirst.Size = new Size(32, 31);
            pctFirst.SizeMode = PictureBoxSizeMode.StretchImage;
            pctFirst.TabIndex = 77;
            pctFirst.TabStop = false;
            pctFirst.Click += Navigation_Handler;
            // 
            // pctNext
            // 
            pctNext.BackColor = Color.Transparent;
            pctNext.Image = (Image)resources.GetObject("pctNext.Image");
            pctNext.Location = new Point(309, 141);
            pctNext.Name = "pctNext";
            pctNext.Size = new Size(32, 31);
            pctNext.SizeMode = PictureBoxSizeMode.StretchImage;
            pctNext.TabIndex = 75;
            pctNext.TabStop = false;
            pctNext.Click += Navigation_Handler;
            // 
            // pctPrevious
            // 
            pctPrevious.BackColor = Color.Transparent;
            pctPrevious.Image = (Image)resources.GetObject("pctPrevious.Image");
            pctPrevious.Location = new Point(248, 141);
            pctPrevious.Name = "pctPrevious";
            pctPrevious.Size = new Size(32, 31);
            pctPrevious.SizeMode = PictureBoxSizeMode.StretchImage;
            pctPrevious.TabIndex = 76;
            pctPrevious.TabStop = false;
            pctPrevious.Click += Navigation_Handler;
            // 
            // pctLast
            // 
            pctLast.BackColor = Color.Transparent;
            pctLast.Image = (Image)resources.GetObject("pctLast.Image");
            pctLast.Location = new Point(370, 141);
            pctLast.Name = "pctLast";
            pctLast.Size = new Size(32, 31);
            pctLast.SizeMode = PictureBoxSizeMode.StretchImage;
            pctLast.TabIndex = 74;
            pctLast.TabStop = false;
            pctLast.Click += Navigation_Handler;
            // 
            // txtBookId
            // 
            txtBookId.ForeColor = Color.Black;
            txtBookId.Location = new Point(413, 391);
            txtBookId.Name = "txtBookId";
            txtBookId.ReadOnly = true;
            txtBookId.Size = new Size(156, 23);
            txtBookId.TabIndex = 79;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Location = new Point(413, 373);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 78;
            lblId.Text = "Id:";
            // 
            // errProvider
            // 
            errProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errProvider.ContainerControl = this;
            // 
            // txtDescription
            // 
            txtDescription.ForeColor = Color.Black;
            txtDescription.Location = new Point(92, 316);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(276, 102);
            txtDescription.TabIndex = 84;
            txtDescription.Tag = "Description";
            txtDescription.Validating += txt_Validating;
            // 
            // btnShowRecords
            // 
            btnShowRecords.Location = new Point(494, 444);
            btnShowRecords.Name = "btnShowRecords";
            btnShowRecords.Size = new Size(91, 23);
            btnShowRecords.TabIndex = 85;
            btnShowRecords.Text = "Show Records";
            btnShowRecords.UseVisualStyleBackColor = true;
            btnShowRecords.Click += btnShowRecords_Click;
            // 
            // frmMaintainBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(659, 548);
            Controls.Add(btnShowRecords);
            Controls.Add(txtDescription);
            Controls.Add(txtBookId);
            Controls.Add(lblId);
            Controls.Add(pctFirst);
            Controls.Add(pctNext);
            Controls.Add(pctPrevious);
            Controls.Add(pctLast);
            Controls.Add(lblAuthor);
            Controls.Add(cmbAuthor);
            Controls.Add(lblGenre);
            Controls.Add(cmbGenre);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(pctbIcon);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtTitle);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(lblPurpose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMaintainBooks";
            Text = "Maintain Books";
            FormClosed += frmMaintainBooks_FormClosed;
            Load += frmMaintainBooks_Load;
            ((System.ComponentModel.ISupportInitialize)pctbIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctFirst).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctPrevious).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctLast).EndInit();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancel;
        private Button btnUpdate;
        private PictureBox pctbIcon;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtTitle;
        private Label lblDescription;
        private Label lblTitle;
        private Label lblPurpose;
        private ComboBox cmbGenre;
        private Label lblGenre;
        private Label lblAuthor;
        private ComboBox cmbAuthor;
        private PictureBox pctFirst;
        private PictureBox pctNext;
        private PictureBox pctPrevious;
        private PictureBox pctLast;
        private TextBox txtBookId;
        private Label lblId;
        private ErrorProvider errProvider;
        private TextBox txtDescription;
        private Button btnShowRecords;
    }
}