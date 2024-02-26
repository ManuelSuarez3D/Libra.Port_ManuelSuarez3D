namespace LibraryAppProject
{
    partial class frmMaintainAuthors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintainAuthors));
            lblLastName = new Label();
            lblFirstName = new Label();
            lblPurpose = new Label();
            lblDescription = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            pctbIcon = new PictureBox();
            btnDelete = new Button();
            btnAdd = new Button();
            btnCancel = new Button();
            btnUpdate = new Button();
            pctFirst = new PictureBox();
            pctNext = new PictureBox();
            pctPrevious = new PictureBox();
            pctLast = new PictureBox();
            txtAuthorId = new TextBox();
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
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Location = new Point(83, 220);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Location = new Point(83, 176);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Name:";
            // 
            // lblPurpose
            // 
            lblPurpose.AutoSize = true;
            lblPurpose.BackColor = Color.Transparent;
            lblPurpose.Font = new Font("Modern No. 20", 35.2499962F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblPurpose.ForeColor = Color.MediumAquamarine;
            lblPurpose.Location = new Point(145, 86);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(362, 48);
            lblPurpose.TabIndex = 5;
            lblPurpose.Text = "Maintain Author";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Location = new Point(83, 264);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "Description:";
            // 
            // txtFirstName
            // 
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(83, 194);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(276, 23);
            txtFirstName.TabIndex = 14;
            txtFirstName.Tag = "First Name";
            txtFirstName.Validating += txt_Validating;
            // 
            // txtLastName
            // 
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(83, 238);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(276, 23);
            txtLastName.TabIndex = 15;
            txtLastName.Tag = "Last Name";
            txtLastName.Validating += txt_Validating;
            // 
            // pctbIcon
            // 
            pctbIcon.BackColor = Color.Transparent;
            pctbIcon.Image = (Image)resources.GetObject("pctbIcon.Image");
            pctbIcon.Location = new Point(408, 194);
            pctbIcon.Name = "pctbIcon";
            pctbIcon.Size = new Size(156, 162);
            pctbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbIcon.TabIndex = 16;
            pctbIcon.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(178, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 33);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ImageAlign = ContentAlignment.BottomCenter;
            btnAdd.Location = new Point(83, 409);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 33);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(368, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(89, 33);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(273, 409);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(89, 33);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // pctFirst
            // 
            pctFirst.BackColor = Color.Transparent;
            pctFirst.Image = (Image)resources.GetObject("pctFirst.Image");
            pctFirst.Location = new Point(178, 157);
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
            pctNext.Location = new Point(300, 157);
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
            pctPrevious.Location = new Point(239, 157);
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
            pctLast.Location = new Point(361, 157);
            pctLast.Name = "pctLast";
            pctLast.Size = new Size(32, 31);
            pctLast.SizeMode = PictureBoxSizeMode.StretchImage;
            pctLast.TabIndex = 74;
            pctLast.TabStop = false;
            pctLast.Click += Navigation_Handler;
            // 
            // txtAuthorId
            // 
            txtAuthorId.ForeColor = Color.Black;
            txtAuthorId.Location = new Point(408, 380);
            txtAuthorId.Name = "txtAuthorId";
            txtAuthorId.ReadOnly = true;
            txtAuthorId.Size = new Size(156, 23);
            txtAuthorId.TabIndex = 81;
            txtAuthorId.Tag = "Author Id";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Location = new Point(408, 362);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 80;
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
            txtDescription.Location = new Point(83, 282);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(276, 104);
            txtDescription.TabIndex = 82;
            txtDescription.Tag = "Description";
            txtDescription.Validating += txt_Validating;
            // 
            // btnShowRecords
            // 
            btnShowRecords.Location = new Point(490, 437);
            btnShowRecords.Name = "btnShowRecords";
            btnShowRecords.Size = new Size(91, 23);
            btnShowRecords.TabIndex = 83;
            btnShowRecords.Text = "Show Records";
            btnShowRecords.UseVisualStyleBackColor = true;
            btnShowRecords.Click += btnShowRecords_Click;
            // 
            // frmMaintainAuthors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(659, 548);
            Controls.Add(btnShowRecords);
            Controls.Add(txtDescription);
            Controls.Add(txtAuthorId);
            Controls.Add(lblId);
            Controls.Add(pctFirst);
            Controls.Add(pctNext);
            Controls.Add(pctPrevious);
            Controls.Add(pctLast);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(pctbIcon);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblDescription);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblPurpose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMaintainAuthors";
            Text = "Maintain Authors";
            FormClosed += frmMaintainAuthors_FormClosed;
            Load += frmMaintainAuthors_Load;
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
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblPurpose;
        private RichTextBox rtxtDescription;
        private Label lblDescription;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private PictureBox pctbIcon;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnUpdate;
        private PictureBox pctFirst;
        private PictureBox pctNext;
        private PictureBox pctPrevious;
        private PictureBox pctLast;
        private TextBox txtAuthorId;
        private Label lblId;
        private ErrorProvider errProvider;
        private TextBox txtDescription;
        private Button btnShowRecords;
    }
}