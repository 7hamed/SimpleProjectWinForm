namespace ToDoList.forms
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
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.treevTask = new System.Windows.Forms.TreeView();
            this.cmTreevTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDeleteTask = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdateTask = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddTask = new Guna.UI2.WinForms.Guna2Button();
            this.imageListCatagory = new System.Windows.Forms.ImageList(this.components);
            this.cmTreevTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.AutoRoundedCorners = true;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(82)))), ((int)(((byte)(11)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(12, 680);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(143, 45);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // treevTask
            // 
            this.treevTask.CheckBoxes = true;
            this.treevTask.ContextMenuStrip = this.cmTreevTask;
            this.treevTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treevTask.FullRowSelect = true;
            this.treevTask.ImageIndex = 0;
            this.treevTask.ImageList = this.imageListCatagory;
            this.treevTask.Location = new System.Drawing.Point(152, 120);
            this.treevTask.Name = "treevTask";
            this.treevTask.SelectedImageIndex = 0;
            this.treevTask.Size = new System.Drawing.Size(626, 450);
            this.treevTask.TabIndex = 6;
            this.treevTask.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treevTask_AfterCheck);
            // 
            // cmTreevTask
            // 
            this.cmTreevTask.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmTreevTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDeleteTask,
            this.tsmUpdateTask});
            this.cmTreevTask.Name = "cmTreevTask";
            this.cmTreevTask.Size = new System.Drawing.Size(159, 52);
            // 
            // tsmDeleteTask
            // 
            this.tsmDeleteTask.Name = "tsmDeleteTask";
            this.tsmDeleteTask.Size = new System.Drawing.Size(158, 24);
            this.tsmDeleteTask.Text = "Delete Task";
            this.tsmDeleteTask.Click += new System.EventHandler(this.tsmDeleteTask_Click);
            // 
            // tsmUpdateTask
            // 
            this.tsmUpdateTask.Name = "tsmUpdateTask";
            this.tsmUpdateTask.Size = new System.Drawing.Size(158, 24);
            this.tsmUpdateTask.Text = "Update Task";
            this.tsmUpdateTask.Click += new System.EventHandler(this.tsmUpdateTask_Click);
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
            this.btnAddTask.Location = new System.Drawing.Point(616, 586);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(162, 45);
            this.btnAddTask.TabIndex = 9;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
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
            this.imageListCatagory.Images.SetKeyName(7, "taskEasy.ico");
            this.imageListCatagory.Images.SetKeyName(8, "taskMedium.ico");
            this.imageListCatagory.Images.SetKeyName(9, "taskHard.ico");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(907, 740);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.treevTask);
            this.Controls.Add(this.btnLogout);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            this.Controls.SetChildIndex(this.treevTask, 0);
            this.Controls.SetChildIndex(this.btnAddTask, 0);
            this.cmTreevTask.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private System.Windows.Forms.TreeView treevTask;
        private System.Windows.Forms.ContextMenuStrip cmTreevTask;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteTask;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateTask;
        private Guna.UI2.WinForms.Guna2Button btnAddTask;
        private System.Windows.Forms.ImageList imageListCatagory;
    }
}