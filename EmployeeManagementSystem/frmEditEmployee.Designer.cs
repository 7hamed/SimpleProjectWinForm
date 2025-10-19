namespace _7_EmployeeManagement
{
    partial class frmEditEmployee
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
            this.gbPersonalInformation = new System.Windows.Forms.GroupBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
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
            this.btnComfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbPersonalInformation.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.gbEmployeeInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPersonalInformation
            // 
            this.gbPersonalInformation.Controls.Add(this.gbGender);
            this.gbPersonalInformation.Controls.Add(this.label6);
            this.gbPersonalInformation.Controls.Add(this.label1);
            this.gbPersonalInformation.Controls.Add(this.dtpDateOfBirth);
            this.gbPersonalInformation.Controls.Add(this.label2);
            this.gbPersonalInformation.Controls.Add(this.label3);
            this.gbPersonalInformation.Controls.Add(this.txtEmail);
            this.gbPersonalInformation.Controls.Add(this.txtPhone);
            this.gbPersonalInformation.Controls.Add(this.txtFullName);
            this.gbPersonalInformation.Location = new System.Drawing.Point(40, 30);
            this.gbPersonalInformation.Name = "gbPersonalInformation";
            this.gbPersonalInformation.Size = new System.Drawing.Size(381, 356);
            this.gbPersonalInformation.TabIndex = 114;
            this.gbPersonalInformation.TabStop = false;
            this.gbPersonalInformation.Text = "Personal Information";
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemaleGender);
            this.gbGender.Controls.Add(this.rbMaleGender);
            this.gbGender.Location = new System.Drawing.Point(38, 263);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(307, 67);
            this.gbGender.TabIndex = 119;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
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
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(142, 159);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(203, 26);
            this.txtPhone.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(142, 59);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(203, 26);
            this.txtFullName.TabIndex = 0;
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
            this.gbEmployeeInformation.Location = new System.Drawing.Point(456, 30);
            this.gbEmployeeInformation.Name = "gbEmployeeInformation";
            this.gbEmployeeInformation.Size = new System.Drawing.Size(320, 261);
            this.gbEmployeeInformation.TabIndex = 119;
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
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(91, 63);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(203, 26);
            this.txtSalary.TabIndex = 6;
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
            // btnComfirm
            // 
            this.btnComfirm.Location = new System.Drawing.Point(476, 343);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Size = new System.Drawing.Size(109, 43);
            this.btnComfirm.TabIndex = 120;
            this.btnComfirm.Text = "Confirm";
            this.btnComfirm.UseVisualStyleBackColor = true;
            this.btnComfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(600, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 43);
            this.btnCancel.TabIndex = 121;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 484);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnComfirm);
            this.Controls.Add(this.gbEmployeeInformation);
            this.Controls.Add(this.gbPersonalInformation);
            this.Name = "frmEditEmployee";
            this.Text = "frmEditEmployee";
            this.Load += new System.EventHandler(this.frmEditEmployee_Load);
            this.gbPersonalInformation.ResumeLayout(false);
            this.gbPersonalInformation.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.gbEmployeeInformation.ResumeLayout(false);
            this.gbEmployeeInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonalInformation;
        private System.Windows.Forms.GroupBox gbGender;
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
        private System.Windows.Forms.Button btnComfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}