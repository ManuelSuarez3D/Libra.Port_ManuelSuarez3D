namespace LibraryAppProject
{
    partial class frmMaintainGenres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintainGenres));
            lblPurpose = new Label();
            lblName = new Label();
            lblDescription = new Label();
            txtName = new TextBox();
            pctGenre = new PictureBox();
            pctNext = new PictureBox();
            pctPrevious = new PictureBox();
            pctLast = new PictureBox();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            pctFirst = new PictureBox();
            txtGenreId = new TextBox();
            lblId = new Label();
            errProvider = new ErrorProvider(components);
            txtDescription = new TextBox();
            btnShowRecords = new Button();
            ((System.ComponentModel.ISupportInitialize)pctGenre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPrevious).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctLast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctFirst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // lblPurpose
            // 
            lblPurpose.AutoSize = true;
            lblPurpose.BackColor = Color.Transparent;
            lblPurpose.Font = new Font("Modern No. 20", 35.2499962F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblPurpose.ForeColor = Color.MediumAquamarine;
            lblPurpose.Location = new Point(158, 80);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(338, 48);
            lblPurpose.TabIndex = 0;
            lblPurpose.Text = "Maintain Genre";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Location = new Point(85, 174);
            lblName.Name = "lblName";
            lblName.Size = new Size(41, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Genre:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Location = new Point(85, 218);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            // 
            // txtName
            // 
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(85, 192);
            txtName.Name = "txtName";
            txtName.Size = new Size(276, 23);
            txtName.TabIndex = 3;
            txtName.Tag = "Genre";
            txtName.Validating += txt_Validating;
            // 
            // pctGenre
            // 
            pctGenre.BackColor = Color.Transparent;
            pctGenre.Image = (Image)resources.GetObject("pctGenre.Image");
            pctGenre.Location = new Point(406, 192);
            pctGenre.Name = "pctGenre";
            pctGenre.Size = new Size(156, 162);
            pctGenre.SizeMode = PictureBoxSizeMode.StretchImage;
            pctGenre.TabIndex = 9;
            pctGenre.TabStop = false;
            // 
            // pctNext
            // 
            pctNext.BackColor = Color.Transparent;
            pctNext.Image = (Image)resources.GetObject("pctNext.Image");
            pctNext.Location = new Point(297, 155);
            pctNext.Name = "pctNext";
            pctNext.Size = new Size(32, 31);
            pctNext.SizeMode = PictureBoxSizeMode.StretchImage;
            pctNext.TabIndex = 33;
            pctNext.TabStop = false;
            pctNext.Click += Navigation_Handler;
            // 
            // pctPrevious
            // 
            pctPrevious.BackColor = Color.Transparent;
            pctPrevious.Image = (Image)resources.GetObject("pctPrevious.Image");
            pctPrevious.Location = new Point(236, 155);
            pctPrevious.Name = "pctPrevious";
            pctPrevious.Size = new Size(32, 31);
            pctPrevious.SizeMode = PictureBoxSizeMode.StretchImage;
            pctPrevious.TabIndex = 34;
            pctPrevious.TabStop = false;
            pctPrevious.Click += Navigation_Handler;
            // 
            // pctLast
            // 
            pctLast.BackColor = Color.Transparent;
            pctLast.Image = (Image)resources.GetObject("pctLast.Image");
            pctLast.Location = new Point(358, 155);
            pctLast.Name = "pctLast";
            pctLast.Size = new Size(32, 31);
            pctLast.SizeMode = PictureBoxSizeMode.StretchImage;
            pctLast.TabIndex = 32;
            pctLast.TabStop = false;
            pctLast.Click += Navigation_Handler;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(369, 407);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(89, 33);
            btnCancel.TabIndex = 77;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(274, 407);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(89, 33);
            btnUpdate.TabIndex = 76;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(179, 407);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 33);
            btnDelete.TabIndex = 75;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(84, 407);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 33);
            btnAdd.TabIndex = 74;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // pctFirst
            // 
            pctFirst.BackColor = Color.Transparent;
            pctFirst.Image = (Image)resources.GetObject("pctFirst.Image");
            pctFirst.Location = new Point(175, 155);
            pctFirst.Name = "pctFirst";
            pctFirst.Size = new Size(32, 31);
            pctFirst.SizeMode = PictureBoxSizeMode.StretchImage;
            pctFirst.TabIndex = 35;
            pctFirst.TabStop = false;
            pctFirst.Click += Navigation_Handler;
            // 
            // txtGenreId
            // 
            txtGenreId.ForeColor = Color.Black;
            txtGenreId.Location = new Point(408, 378);
            txtGenreId.Name = "txtGenreId";
            txtGenreId.ReadOnly = true;
            txtGenreId.Size = new Size(154, 23);
            txtGenreId.TabIndex = 79;
            txtGenreId.Tag = "Genre Id";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Location = new Point(408, 360);
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
            txtDescription.Location = new Point(85, 236);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(276, 152);
            txtDescription.TabIndex = 83;
            txtDescription.Tag = "Description";
            txtDescription.Validating += txt_Validating;
            // 
            // btnShowRecords
            // 
            btnShowRecords.Location = new Point(485, 433);
            btnShowRecords.Name = "btnShowRecords";
            btnShowRecords.Size = new Size(91, 23);
            btnShowRecords.TabIndex = 86;
            btnShowRecords.Text = "Show Records";
            btnShowRecords.UseVisualStyleBackColor = true;
            btnShowRecords.Click += btnShowRecords_Click;
            // 
            // frmMaintainGenres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(659, 548);
            Controls.Add(btnShowRecords);
            Controls.Add(txtDescription);
            Controls.Add(txtGenreId);
            Controls.Add(lblId);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(pctFirst);
            Controls.Add(pctNext);
            Controls.Add(pctPrevious);
            Controls.Add(pctLast);
            Controls.Add(pctGenre);
            Controls.Add(txtName);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(lblPurpose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmMaintainGenres";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Maintain Genres";
            FormClosed += frmMaintainGenres_FormClosed;
            Load += frmMaintainGenres_Load;
            ((System.ComponentModel.ISupportInitialize)pctGenre).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctPrevious).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctLast).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctFirst).EndInit();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPurpose;
        private Label lblName;
        private Label lblDescription;
        private TextBox txtName;
        private PictureBox pctGenre;
        private PictureBox pctNext;
        private PictureBox pctPrevious;
        private PictureBox pctLast;
        private Button btnCancel;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private PictureBox pctFirst;
        private TextBox txtGenreId;
        private Label lblId;
        private ErrorProvider errProvider;
        private TextBox txtDescription;
        private Button btnShowRecords;
    }
}