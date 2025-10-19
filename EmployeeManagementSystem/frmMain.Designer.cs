namespace _7_EmployeeManagement
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lvMain = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbPersonalInformation = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFemaleGender = new System.Windows.Forms.RadioButton();
            this.rbMaleGender = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbEmployeeInformation = new System.Windows.Forms.GroupBox();
            this.mtxtWorkTo = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtWorkFrom = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbListViewFormat = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnChangeBackColor = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAllInOneVersion = new System.Windows.Forms.Button();
            this.gbPersonalInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbEmployeeInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvMain
            // 
            this.lvMain.HideSelection = false;
            this.lvMain.LargeImageList = this.imageList2;
            this.lvMain.Location = new System.Drawing.Point(52, 429);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(1376, 200);
            this.lvMain.SmallImageList = this.imageList1;
            this.lvMain.TabIndex = 14;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            this.lvMain.DoubleClick += new System.EventHandler(this.lvMain_DoubleClick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "female.png");
            this.imageList2.Images.SetKeyName(1, "male.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "female.png");
            this.imageList1.Images.SetKeyName(1, "male.png");
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(142, 59);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(203, 26);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.Validating += new System.ComponentModel.CancelEventHandler(this.validatingTextBox);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(142, 159);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(203, 26);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.validatingTextBox);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(91, 63);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(203, 26);
            this.txtSalary.TabIndex = 6;
            this.txtSalary.Validating += new System.ComponentModel.CancelEventHandler(this.txtSalary_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 106;
            this.label2.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 107;
            this.label3.Text = "phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 109;
            this.label5.Text = "Salary";
            // 
            // gbPersonalInformation
            // 
            this.gbPersonalInformation.Controls.Add(this.groupBox1);
            this.gbPersonalInformation.Controls.Add(this.label6);
            this.gbPersonalInformation.Controls.Add(this.label1);
            this.gbPersonalInformation.Controls.Add(this.dtpDateOfBirth);
            this.gbPersonalInformation.Controls.Add(this.label2);
            this.gbPersonalInformation.Controls.Add(this.label3);
            this.gbPersonalInformation.Controls.Add(this.txtEmail);
            this.gbPersonalInformation.Controls.Add(this.txtPhone);
            this.gbPersonalInformation.Controls.Add(this.txtFullName);
            this.gbPersonalInformation.Location = new System.Drawing.Point(30, 25);
            this.gbPersonalInformation.Name = "gbPersonalInformation";
            this.gbPersonalInformation.Size = new System.Drawing.Size(381, 356);
            this.gbPersonalInformation.TabIndex = 113;
            this.gbPersonalInformation.TabStop = false;
            this.gbPersonalInformation.Text = "Personal Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFemaleGender);
            this.groupBox1.Controls.Add(this.rbMaleGender);
            this.groupBox1.Location = new System.Drawing.Point(38, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 67);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rbFemaleGender
            // 
            this.rbFemaleGender.AutoSize = true;
            this.rbFemaleGender.Checked = true;
            this.rbFemaleGender.Location = new System.Drawing.Point(197, 25);
            this.rbFemaleGender.Name = "rbFemaleGender";
            this.rbFemaleGender.Size = new System.Drawing.Size(87, 24);
            this.rbFemaleGender.TabIndex = 5;
            this.rbFemaleGender.TabStop = true;
            this.rbFemaleGender.Text = "Female";
            this.rbFemaleGender.UseVisualStyleBackColor = true;
            // 
            // rbMaleGender
            // 
            this.rbMaleGender.AutoSize = true;
            this.rbMaleGender.Location = new System.Drawing.Point(105, 25);
            this.rbMaleGender.Name = "rbMaleGender";
            this.rbMaleGender.Size = new System.Drawing.Size(68, 24);
            this.rbMaleGender.TabIndex = 4;
            this.rbMaleGender.TabStop = true;
            this.rbMaleGender.Text = "Male";
            this.rbMaleGender.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 118;
            this.label6.Text = "Date of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 115;
            this.label1.Text = "Full Name";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(142, 209);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(203, 26);
            this.dtpDateOfBirth.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(142, 109);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 26);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.validatingTextBox);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(91, 113);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(203, 26);
            this.txtID.TabIndex = 7;
            this.txtID.Validating += new System.ComponentModel.CancelEventHandler(this.validatingTextBox);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 116;
            this.label4.Text = "ID";
            // 
            // gbEmployeeInformation
            // 
            this.gbEmployeeInformation.Controls.Add(this.mtxtWorkTo);
            this.gbEmployeeInformation.Controls.Add(this.label9);
            this.gbEmployeeInformation.Controls.Add(this.label8);
            this.gbEmployeeInformation.Controls.Add(this.mtxtWorkFrom);
            this.gbEmployeeInformation.Controls.Add(this.label7);
            this.gbEmployeeInformation.Controls.Add(this.txtID);
            this.gbEmployeeInformation.Controls.Add(this.txtSalary);
            this.gbEmployeeInformation.Controls.Add(this.label5);
            this.gbEmployeeInformation.Controls.Add(this.label4);
            this.gbEmployeeInformation.Location = new System.Drawing.Point(437, 30);
            this.gbEmployeeInformation.Name = "gbEmployeeInformation";
            this.gbEmployeeInformation.Size = new System.Drawing.Size(320, 261);
            this.gbEmployeeInformation.TabIndex = 118;
            this.gbEmployeeInformation.TabStop = false;
            this.gbEmployeeInformation.Text = "Employee Information";
            // 
            // mtxtWorkTo
            // 
            this.mtxtWorkTo.Location = new System.Drawing.Point(212, 209);
            this.mtxtWorkTo.Mask = "00:00";
            this.mtxtWorkTo.Name = "mtxtWorkTo";
            this.mtxtWorkTo.Size = new System.Drawing.Size(79, 26);
            this.mtxtWorkTo.TabIndex = 9;
            this.mtxtWorkTo.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 20);
            this.label9.TabIndex = 121;
            this.label9.Text = "To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 120;
            this.label8.Text = "From";
            // 
            // mtxtWorkFrom
            // 
            this.mtxtWorkFrom.Location = new System.Drawing.Point(75, 209);
            this.mtxtWorkFrom.Mask = "00:00";
            this.mtxtWorkFrom.Name = "mtxtWorkFrom";
            this.mtxtWorkFrom.Size = new System.Drawing.Size(79, 26);
            this.mtxtWorkFrom.TabIndex = 8;
            this.mtxtWorkFrom.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 118;
            this.label7.Text = "Time of Work";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(465, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 43);
            this.btnAdd.TabIndex = 100;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(606, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 43);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(747, 346);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(135, 43);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cbListViewFormat
            // 
            this.cbListViewFormat.AllowDrop = true;
            this.cbListViewFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListViewFormat.FormattingEnabled = true;
            this.cbListViewFormat.Items.AddRange(new object[] {
            "Details",
            "Large Icon",
            "Small Icon",
            "List",
            "Title"});
            this.cbListViewFormat.Location = new System.Drawing.Point(1036, 353);
            this.cbListViewFormat.Name = "cbListViewFormat";
            this.cbListViewFormat.Size = new System.Drawing.Size(178, 28);
            this.cbListViewFormat.TabIndex = 13;
            this.cbListViewFormat.SelectedIndexChanged += new System.EventHandler(this.cbListViewFormat_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(934, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 122;
            this.label10.Text = "list view type";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(773, 248);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(135, 43);
            this.btnRandom.TabIndex = 123;
            this.btnRandom.Text = "random data";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 100;
            this.errorProvider1.ContainerControl = this;
            // 
            // btnChangeBackColor
            // 
            this.btnChangeBackColor.Location = new System.Drawing.Point(773, 194);
            this.btnChangeBackColor.Name = "btnChangeBackColor";
            this.btnChangeBackColor.Size = new System.Drawing.Size(156, 43);
            this.btnChangeBackColor.TabIndex = 124;
            this.btnChangeBackColor.Text = "change back color";
            this.btnChangeBackColor.UseVisualStyleBackColor = true;
            this.btnChangeBackColor.Click += new System.EventHandler(this.btnChangeBackColor_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(961, 257);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 125;
            this.numericUpDown1.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnAllInOneVersion
            // 
            this.btnAllInOneVersion.BackColor = System.Drawing.Color.Silver;
            this.btnAllInOneVersion.Location = new System.Drawing.Point(1086, 42);
            this.btnAllInOneVersion.Name = "btnAllInOneVersion";
            this.btnAllInOneVersion.Size = new System.Drawing.Size(147, 77);
            this.btnAllInOneVersion.TabIndex = 126;
            this.btnAllInOneVersion.Text = "Open All In One Version";
            this.btnAllInOneVersion.UseVisualStyleBackColor = false;
            this.btnAllInOneVersion.Click += new System.EventHandler(this.btnAllInOneVersion_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 745);
            this.Controls.Add(this.btnAllInOneVersion);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnChangeBackColor);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbListViewFormat);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbEmployeeInformation);
            this.Controls.Add(this.gbPersonalInformation);
            this.Controls.Add(this.lvMain);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.gbPersonalInformation.ResumeLayout(false);
            this.gbPersonalInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEmployeeInformation.ResumeLayout(false);
            this.gbEmployeeInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbPersonalInformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemaleGender;
        private System.Windows.Forms.RadioButton rbMaleGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbEmployeeInformation;
        private System.Windows.Forms.MaskedTextBox mtxtWorkTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtWorkFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbListViewFormat;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnChangeBackColor;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAllInOneVersion;
    }
}

