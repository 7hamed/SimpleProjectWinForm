namespace ToDoList.forms
{
    partial class frmAddTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTask));
            this.txtTaskName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddTask = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.cbCategoryTask = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatagoryName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbGatagoryImage = new System.Windows.Forms.PictureBox();
            this.cbCatagoryImage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imageListCatagory = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTaskMode = new System.Windows.Forms.ComboBox();
            this.pbTaskMode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGatagoryImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaskMode)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTaskName
            // 
            this.txtTaskName.Animated = true;
            this.txtTaskName.AutoRoundedCorners = true;
            this.txtTaskName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaskName.DefaultText = "";
            this.txtTaskName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaskName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaskName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskName.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtTaskName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskName.Location = new System.Drawing.Point(511, 145);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.PlaceholderText = "";
            this.txtTaskName.SelectedText = "";
            this.txtTaskName.Size = new System.Drawing.Size(340, 45);
            this.txtTaskName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(524, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Task Name";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Animated = true;
            this.btnAddTask.AutoRoundedCorners = true;
            this.btnAddTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(672, 475);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(143, 45);
            this.btnAddTask.TabIndex = 5;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(82)))), ((int)(((byte)(11)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(511, 475);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 45);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbCategoryTask
            // 
            this.cbCategoryTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoryTask.FormattingEnabled = true;
            this.cbCategoryTask.Items.AddRange(new object[] {
            "New"});
            this.cbCategoryTask.Location = new System.Drawing.Point(58, 163);
            this.cbCategoryTask.Name = "cbCategoryTask";
            this.cbCategoryTask.Size = new System.Drawing.Size(220, 37);
            this.cbCategoryTask.TabIndex = 0;
            this.cbCategoryTask.SelectedIndexChanged += new System.EventHandler(this.cbCategoryTask_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Catagory Name";
            // 
            // txtCatagoryName
            // 
            this.txtCatagoryName.Animated = true;
            this.txtCatagoryName.AutoRoundedCorners = true;
            this.txtCatagoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCatagoryName.DefaultText = "";
            this.txtCatagoryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCatagoryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCatagoryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCatagoryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCatagoryName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCatagoryName.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtCatagoryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCatagoryName.Location = new System.Drawing.Point(58, 383);
            this.txtCatagoryName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCatagoryName.Name = "txtCatagoryName";
            this.txtCatagoryName.PlaceholderText = "";
            this.txtCatagoryName.SelectedText = "";
            this.txtCatagoryName.Size = new System.Drawing.Size(340, 45);
            this.txtCatagoryName.TabIndex = 2;
            // 
            // pbGatagoryImage
            // 
            this.pbGatagoryImage.Location = new System.Drawing.Point(58, 264);
            this.pbGatagoryImage.Name = "pbGatagoryImage";
            this.pbGatagoryImage.Size = new System.Drawing.Size(50, 50);
            this.pbGatagoryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGatagoryImage.TabIndex = 13;
            this.pbGatagoryImage.TabStop = false;
            // 
            // cbCatagoryImage
            // 
            this.cbCatagoryImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCatagoryImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCatagoryImage.FormattingEnabled = true;
            this.cbCatagoryImage.Items.AddRange(new object[] {
            "Pin",
            "IQ",
            "Money",
            "Health",
            "Work",
            "Daily",
            "Education"});
            this.cbCatagoryImage.Location = new System.Drawing.Point(125, 271);
            this.cbCatagoryImage.Name = "cbCatagoryImage";
            this.cbCatagoryImage.Size = new System.Drawing.Size(180, 37);
            this.cbCatagoryImage.TabIndex = 1;
            this.cbCatagoryImage.SelectedIndexChanged += new System.EventHandler(this.cbCatagoryImage_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Choose Catagory";
            // 
            // imageListCatagory
            // 
            this.imageListCatagory.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCatagory.ImageStream")));
            this.imageListCatagory.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCatagory.Images.SetKeyName(0, "pin.ico");
            this.imageListCatagory.Images.SetKeyName(1, "brain.ico");
            this.imageListCatagory.Images.SetKeyName(2, "money.ico");
            this.imageListCatagory.Images.SetKeyName(3, "heart.ico");
            this.imageListCatagory.Images.SetKeyName(4, "work.ico");
            this.imageListCatagory.Images.SetKeyName(5, "daily.ico");
            this.imageListCatagory.Images.SetKeyName(6, "education.ico");
            this.imageListCatagory.Images.SetKeyName(7, "easy.ico");
            this.imageListCatagory.Images.SetKeyName(8, "medium.ico");
            this.imageListCatagory.Images.SetKeyName(9, "hard.ico");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Catagory Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(524, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Task Mode";
            // 
            // cbTaskMode
            // 
            this.cbTaskMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaskMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTaskMode.FormattingEnabled = true;
            this.cbTaskMode.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cbTaskMode.Location = new System.Drawing.Point(578, 271);
            this.cbTaskMode.Name = "cbTaskMode";
            this.cbTaskMode.Size = new System.Drawing.Size(180, 37);
            this.cbTaskMode.TabIndex = 4;
            this.cbTaskMode.SelectedIndexChanged += new System.EventHandler(this.cbTaskMode_SelectedIndexChanged);
            // 
            // pbTaskMode
            // 
            this.pbTaskMode.Location = new System.Drawing.Point(511, 264);
            this.pbTaskMode.Name = "pbTaskMode";
            this.pbTaskMode.Size = new System.Drawing.Size(50, 50);
            this.pbTaskMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTaskMode.TabIndex = 17;
            this.pbTaskMode.TabStop = false;
            // 
            // frmAddTask
            // 
            this.AcceptButton = this.btnAddTask;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(903, 558);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTaskMode);
            this.Controls.Add(this.pbTaskMode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCatagoryImage);
            this.Controls.Add(this.pbGatagoryImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCatagoryName);
            this.Controls.Add(this.cbCategoryTask);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTaskName);
            this.Name = "frmAddTask";
            this.Text = "frmAddTask";
            this.Load += new System.EventHandler(this.frmAddTask_Load);
            this.Controls.SetChildIndex(this.txtTaskName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnAddTask, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.cbCategoryTask, 0);
            this.Controls.SetChildIndex(this.txtCatagoryName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pbGatagoryImage, 0);
            this.Controls.SetChildIndex(this.cbCatagoryImage, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.pbTaskMode, 0);
            this.Controls.SetChildIndex(this.cbTaskMode, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbGatagoryImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaskMode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtTaskName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnAddTask;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.ComboBox cbCategoryTask;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtCatagoryName;
        private System.Windows.Forms.PictureBox pbGatagoryImage;
        private System.Windows.Forms.ComboBox cbCatagoryImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageListCatagory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTaskMode;
        private System.Windows.Forms.PictureBox pbTaskMode;
    }
}