namespace ToDoList.forms
{
    partial class frmUpdateTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateTask));
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.cbCatagoryImage = new System.Windows.Forms.ComboBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.imageListCatagory = new System.Windows.Forms.ImageList(this.components);
            this.cbTaskMode = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancel.FillColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(555, 497);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 45);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(716, 497);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 45);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "New Name";
            // 
            // txtNewName
            // 
            this.txtNewName.Animated = true;
            this.txtNewName.AutoRoundedCorners = true;
            this.txtNewName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewName.DefaultText = "";
            this.txtNewName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewName.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtNewName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewName.Location = new System.Drawing.Point(271, 187);
            this.txtNewName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.PlaceholderText = "";
            this.txtNewName.SelectedText = "";
            this.txtNewName.Size = new System.Drawing.Size(340, 45);
            this.txtNewName.TabIndex = 10;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(284, 275);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(119, 25);
            this.lblImage.TabIndex = 14;
            this.lblImage.Text = "New Image";
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
            this.cbCatagoryImage.Location = new System.Drawing.Point(338, 312);
            this.cbCatagoryImage.Name = "cbCatagoryImage";
            this.cbCatagoryImage.Size = new System.Drawing.Size(180, 37);
            this.cbCatagoryImage.TabIndex = 16;
            this.cbCatagoryImage.SelectedIndexChanged += new System.EventHandler(this.cbCatagoryImage_SelectedIndexChanged);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(271, 305);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(50, 50);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 15;
            this.pbImage.TabStop = false;
            // 
            // imageListCatagory
            // 
            this.imageListCatagory.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCatagory.ImageStream")));
            this.imageListCatagory.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCatagory.Images.SetKeyName(0, "pin.ico");
            this.imageListCatagory.Images.SetKeyName(1, "personal.ico");
            this.imageListCatagory.Images.SetKeyName(2, "money.ico");
            this.imageListCatagory.Images.SetKeyName(3, "health.ico");
            this.imageListCatagory.Images.SetKeyName(4, "work.ico");
            this.imageListCatagory.Images.SetKeyName(5, "Daily.ico");
            this.imageListCatagory.Images.SetKeyName(6, "Education.ico");
            this.imageListCatagory.Images.SetKeyName(7, "easy.ico");
            this.imageListCatagory.Images.SetKeyName(8, "medium.ico");
            this.imageListCatagory.Images.SetKeyName(9, "hard.ico");
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
            this.cbTaskMode.Location = new System.Drawing.Point(338, 312);
            this.cbTaskMode.Name = "cbTaskMode";
            this.cbTaskMode.Size = new System.Drawing.Size(180, 37);
            this.cbTaskMode.TabIndex = 17;
            this.cbTaskMode.SelectedIndexChanged += new System.EventHandler(this.cbTaskMode_SelectedIndexChanged);
            // 
            // frmUpdateTask
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(910, 578);
            this.Controls.Add(this.cbTaskMode);
            this.Controls.Add(this.cbCatagoryImage);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewName);
            this.Name = "frmUpdateTask";
            this.Text = "frmUpdateTask";
            this.Load += new System.EventHandler(this.frmUpdateTask_Load);
            this.Shown += new System.EventHandler(this.frmUpdateTask_Shown);
            this.Controls.SetChildIndex(this.txtNewName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblImage, 0);
            this.Controls.SetChildIndex(this.pbImage, 0);
            this.Controls.SetChildIndex(this.cbCatagoryImage, 0);
            this.Controls.SetChildIndex(this.cbTaskMode, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtNewName;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.ComboBox cbCatagoryImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ImageList imageListCatagory;
        private System.Windows.Forms.ComboBox cbTaskMode;
    }
}