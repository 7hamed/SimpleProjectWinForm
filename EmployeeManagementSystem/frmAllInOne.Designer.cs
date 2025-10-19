namespace _7_EmployeeManagement
{
    partial class frmAllInOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllInOne));
            this.tabcMain = new System.Windows.Forms.TabControl();
            this.tabpMainScreen = new System.Windows.Forms.TabPage();
            this.btnChangeFont = new System.Windows.Forms.Button();
            this.btnChangeTabColor = new System.Windows.Forms.Button();
            this.btnChangeBackColor = new System.Windows.Forms.Button();
            this.btnShowEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.tabpageAddEmployee = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbPersonalInformation = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFemaleGender = new System.Windows.Forms.RadioButton();
            this.rbMaleGender = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.gbEmployeeInformation = new System.Windows.Forms.GroupBox();
            this.mtxtWorkTo = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtWorkFrom = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabpageShowEmployee = new System.Windows.Forms.TabPage();
            this.btnChangeListViewColor = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbListViewType = new System.Windows.Forms.ComboBox();
            this.lvEmployee = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colorDialogTabc = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tabcMain.SuspendLayout();
            this.tabpMainScreen.SuspendLayout();
            this.tabpageAddEmployee.SuspendLayout();
            this.gbPersonalInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbEmployeeInformation.SuspendLayout();
            this.tabpageShowEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcMain
            // 
            this.tabcMain.Controls.Add(this.tabpMainScreen);
            this.tabcMain.Controls.Add(this.tabpageAddEmployee);
            this.tabcMain.Controls.Add(this.tabpageShowEmployee);
            this.tabcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcMain.ImageList = this.imageList3;
            this.tabcMain.Location = new System.Drawing.Point(0, 0);
            this.tabcMain.Name = "tabcMain";
            this.tabcMain.SelectedIndex = 0;
            this.tabcMain.Size = new System.Drawing.Size(1251, 624);
            this.tabcMain.TabIndex = 0;
            // 
            // tabpMainScreen
            // 
            this.tabpMainScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabpMainScreen.Controls.Add(this.btnChangeFont);
            this.tabpMainScreen.Controls.Add(this.btnChangeTabColor);
            this.tabpMainScreen.Controls.Add(this.btnChangeBackColor);
            this.tabpMainScreen.Controls.Add(this.btnShowEmployee);
            this.tabpMainScreen.Controls.Add(this.btnAddEmployee);
            this.tabpMainScreen.ImageIndex = 2;
            this.tabpMainScreen.Location = new System.Drawing.Point(4, 31);
            this.tabpMainScreen.Name = "tabpMainScreen";
            this.tabpMainScreen.Size = new System.Drawing.Size(1243, 589);
            this.tabpMainScreen.TabIndex = 0;
            this.tabpMainScreen.Text = "Main Screen";
            this.tabpMainScreen.UseVisualStyleBackColor = true;
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Location = new System.Drawing.Point(764, 369);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(118, 61);
            this.btnChangeFont.TabIndex = 1;
            this.btnChangeFont.Text = "change font";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // btnChangeTabColor
            // 
            this.btnChangeTabColor.Location = new System.Drawing.Point(573, 442);
            this.btnChangeTabColor.Name = "btnChangeTabColor";
            this.btnChangeTabColor.Size = new System.Drawing.Size(164, 58);
            this.btnChangeTabColor.TabIndex = 137;
            this.btnChangeTabColor.Text = "change Tabs Color";
            this.btnChangeTabColor.UseVisualStyleBackColor = true;
            this.btnChangeTabColor.Click += new System.EventHandler(this.btnChangeTabColor_Click);
            // 
            // btnChangeBackColor
            // 
            this.btnChangeBackColor.Location = new System.Drawing.Point(573, 369);
            this.btnChangeBackColor.Name = "btnChangeBackColor";
            this.btnChangeBackColor.Size = new System.Drawing.Size(164, 58);
            this.btnChangeBackColor.TabIndex = 136;
            this.btnChangeBackColor.Text = "change back color";
            this.btnChangeBackColor.UseVisualStyleBackColor = true;
            this.btnChangeBackColor.Click += new System.EventHandler(this.btnChangeBackColor_Click);
            // 
            // btnShowEmployee
            // 
            this.btnShowEmployee.Location = new System.Drawing.Point(379, 442);
            this.btnShowEmployee.Name = "btnShowEmployee";
            this.btnShowEmployee.Size = new System.Drawing.Size(164, 58);
            this.btnShowEmployee.TabIndex = 1;
            this.btnShowEmployee.Text = "Show Employee";
            this.btnShowEmployee.UseVisualStyleBackColor = true;
            this.btnShowEmployee.Click += new System.EventHandler(this.btnShowEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(379, 369);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(164, 58);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // tabpageAddEmployee
            // 
            this.tabpageAddEmployee.Controls.Add(this.btnAdd);
            this.tabpageAddEmployee.Controls.Add(this.gbPersonalInformation);
            this.tabpageAddEmployee.Controls.Add(this.gbEmployeeInformation);
            this.tabpageAddEmployee.ImageIndex = 1;
            this.tabpageAddEmployee.Location = new System.Drawing.Point(4, 31);
            this.tabpageAddEmployee.Name = "tabpageAddEmployee";
            this.tabpageAddEmployee.Size = new System.Drawing.Size(1243, 589);
            this.tabpageAddEmployee.TabIndex = 1;
            this.tabpageAddEmployee.Text = "Add Employee";
            this.tabpageAddEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(438, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 43);
            this.btnAdd.TabIndex = 130;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.gbPersonalInformation.Location = new System.Drawing.Point(31, 23);
            this.gbPersonalInformation.Name = "gbPersonalInformation";
            this.gbPersonalInformation.Size = new System.Drawing.Size(381, 356);
            this.gbPersonalInformation.TabIndex = 131;
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
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(142, 109);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 26);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.validatingTextBox);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(142, 159);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(203, 26);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.validatingTextBox);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(142, 59);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(203, 26);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.Validating += new System.ComponentModel.CancelEventHandler(this.validatingTextBox);
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
            this.gbEmployeeInformation.Location = new System.Drawing.Point(438, 28);
            this.gbEmployeeInformation.Name = "gbEmployeeInformation";
            this.gbEmployeeInformation.Size = new System.Drawing.Size(320, 261);
            this.gbEmployeeInformation.TabIndex = 132;
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
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(91, 113);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(203, 26);
            this.txtID.TabIndex = 7;
            this.txtID.Validating += new System.ComponentModel.CancelEventHandler(this.validatingTextBox);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(91, 63);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(203, 26);
            this.txtSalary.TabIndex = 6;
            this.txtSalary.Validating += new System.ComponentModel.CancelEventHandler(this.txtSalary_Validating);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 116;
            this.label4.Text = "ID";
            // 
            // tabpageShowEmployee
            // 
            this.tabpageShowEmployee.Controls.Add(this.btnChangeListViewColor);
            this.tabpageShowEmployee.Controls.Add(this.btnRandom);
            this.tabpageShowEmployee.Controls.Add(this.btnEdit);
            this.tabpageShowEmployee.Controls.Add(this.btnDelete);
            this.tabpageShowEmployee.Controls.Add(this.cbListViewType);
            this.tabpageShowEmployee.Controls.Add(this.lvEmployee);
            this.tabpageShowEmployee.ImageIndex = 0;
            this.tabpageShowEmployee.Location = new System.Drawing.Point(4, 31);
            this.tabpageShowEmployee.Name = "tabpageShowEmployee";
            this.tabpageShowEmployee.Size = new System.Drawing.Size(1243, 589);
            this.tabpageShowEmployee.TabIndex = 2;
            this.tabpageShowEmployee.Text = "Show Employee";
            this.tabpageShowEmployee.UseVisualStyleBackColor = true;
            // 
            // btnChangeListViewColor
            // 
            this.btnChangeListViewColor.Location = new System.Drawing.Point(891, 27);
            this.btnChangeListViewColor.Name = "btnChangeListViewColor";
            this.btnChangeListViewColor.Size = new System.Drawing.Size(172, 43);
            this.btnChangeListViewColor.TabIndex = 138;
            this.btnChangeListViewColor.Text = "change back color";
            this.btnChangeListViewColor.UseVisualStyleBackColor = true;
            this.btnChangeListViewColor.Click += new System.EventHandler(this.btnChangeListViewColor_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(750, 27);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(135, 43);
            this.btnRandom.TabIndex = 137;
            this.btnRandom.Text = "random data";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(607, 27);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(135, 43);
            this.btnEdit.TabIndex = 136;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(466, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 43);
            this.btnDelete.TabIndex = 135;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbListViewType
            // 
            this.cbListViewType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListViewType.FormattingEnabled = true;
            this.cbListViewType.Items.AddRange(new object[] {
            "Details",
            "Large Icon",
            "Small Icon",
            "List",
            "Title"});
            this.cbListViewType.Location = new System.Drawing.Point(293, 35);
            this.cbListViewType.Name = "cbListViewType";
            this.cbListViewType.Size = new System.Drawing.Size(121, 28);
            this.cbListViewType.TabIndex = 1;
            this.cbListViewType.SelectedIndexChanged += new System.EventHandler(this.cbListViewType_SelectedIndexChanged);
            // 
            // lvEmployee
            // 
            this.lvEmployee.HideSelection = false;
            this.lvEmployee.LargeImageList = this.imageList2;
            this.lvEmployee.Location = new System.Drawing.Point(91, 108);
            this.lvEmployee.Name = "lvEmployee";
            this.lvEmployee.Size = new System.Drawing.Size(1072, 459);
            this.lvEmployee.SmallImageList = this.imageList1;
            this.lvEmployee.TabIndex = 0;
            this.lvEmployee.UseCompatibleStateImageBehavior = false;
            this.lvEmployee.DoubleClick += new System.EventHandler(this.lvEmployee_DoubleClick);
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
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "view_details.ico");
            this.imageList3.Images.SetKeyName(1, "add.ico");
            this.imageList3.Images.SetKeyName(2, "house.ico");
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 100;
            this.errorProvider1.ContainerControl = this;
            // 
            // colorDialogTabc
            // 
            this.colorDialogTabc.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // frmAllInOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 624);
            this.Controls.Add(this.tabcMain);
            this.Name = "frmAllInOne";
            this.Text = "frmAllInOne";
            this.Load += new System.EventHandler(this.frmAllInOne_Load);
            this.tabcMain.ResumeLayout(false);
            this.tabpMainScreen.ResumeLayout(false);
            this.tabpageAddEmployee.ResumeLayout(false);
            this.gbPersonalInformation.ResumeLayout(false);
            this.gbPersonalInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEmployeeInformation.ResumeLayout(false);
            this.gbEmployeeInformation.PerformLayout();
            this.tabpageShowEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcMain;
        private System.Windows.Forms.TabPage tabpMainScreen;
        private System.Windows.Forms.TabPage tabpageAddEmployee;
        private System.Windows.Forms.TabPage tabpageShowEmployee;
        private System.Windows.Forms.Button btnShowEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbPersonalInformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemaleGender;
        private System.Windows.Forms.RadioButton rbMaleGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.GroupBox gbEmployeeInformation;
        private System.Windows.Forms.MaskedTextBox mtxtWorkTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtWorkFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Button btnChangeBackColor;
        private System.Windows.Forms.ListView lvEmployee;
        private System.Windows.Forms.ComboBox cbListViewType;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColorDialog colorDialogTabc;
        private System.Windows.Forms.Button btnChangeListViewColor;
        private System.Windows.Forms.Button btnChangeTabColor;
        private System.Windows.Forms.Button btnChangeFont;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}