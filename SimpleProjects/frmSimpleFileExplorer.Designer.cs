namespace _4_testForms
{
    partial class frmSimpleFileExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimpleFileExplorer));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node11", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node12", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node13", 1, 1);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("pdfs", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node9", 2, 2);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node10", 2, 2);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("study", 4, 3, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node14", 2, 2);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node15", 2, 2);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("games", 4, 3, new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node16", 0, 0);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node17", 0, 0);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node18", 0, 0);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("art", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            this.imglMain = new System.Windows.Forms.ImageList(this.components);
            this.tvFolder = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imglMain
            // 
            this.imglMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglMain.ImageStream")));
            this.imglMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imglMain.Images.SetKeyName(0, "file_csv.png");
            this.imglMain.Images.SetKeyName(1, "files.png");
            this.imglMain.Images.SetKeyName(2, "file.png");
            this.imglMain.Images.SetKeyName(3, "folder_open.png");
            this.imglMain.Images.SetKeyName(4, "folder.png");
            // 
            // tvFolder
            // 
            this.tvFolder.CheckBoxes = true;
            this.tvFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvFolder.ImageIndex = 4;
            this.tvFolder.ImageList = this.imglMain;
            this.tvFolder.Location = new System.Drawing.Point(43, 70);
            this.tvFolder.Name = "tvFolder";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Node11";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Node11";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Node12";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Node12";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "Node13";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Node13";
            treeNode4.ImageIndex = 4;
            treeNode4.Name = "Node8";
            treeNode4.Text = "pdfs";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "Node9";
            treeNode5.SelectedImageIndex = 2;
            treeNode5.Text = "Node9";
            treeNode6.ImageIndex = 2;
            treeNode6.Name = "Node10";
            treeNode6.SelectedImageIndex = 2;
            treeNode6.Text = "Node10";
            treeNode7.ImageIndex = 4;
            treeNode7.Name = "Node0";
            treeNode7.SelectedImageIndex = 3;
            treeNode7.Text = "study";
            treeNode8.ImageIndex = 2;
            treeNode8.Name = "Node14";
            treeNode8.SelectedImageIndex = 2;
            treeNode8.Text = "Node14";
            treeNode9.ImageIndex = 2;
            treeNode9.Name = "Node15";
            treeNode9.SelectedImageIndex = 2;
            treeNode9.Text = "Node15";
            treeNode10.ImageIndex = 4;
            treeNode10.Name = "Node1";
            treeNode10.SelectedImageIndex = 3;
            treeNode10.Text = "games";
            treeNode11.ImageIndex = 0;
            treeNode11.Name = "Node16";
            treeNode11.SelectedImageIndex = 0;
            treeNode11.Text = "Node16";
            treeNode12.ImageIndex = 0;
            treeNode12.Name = "Node17";
            treeNode12.SelectedImageIndex = 0;
            treeNode12.Text = "Node17";
            treeNode13.ImageIndex = 0;
            treeNode13.Name = "Node18";
            treeNode13.SelectedImageIndex = 0;
            treeNode13.Text = "Node18";
            treeNode14.ImageIndex = 4;
            treeNode14.Name = "Node2";
            treeNode14.Text = "art";
            this.tvFolder.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode10,
            treeNode14});
            this.tvFolder.SelectedImageIndex = 3;
            this.tvFolder.Size = new System.Drawing.Size(441, 386);
            this.tvFolder.TabIndex = 0;
            this.tvFolder.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvFolder_AfterCheck);
            this.tvFolder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFolder_AfterSelect);
            this.tvFolder.DoubleClick += new System.EventHandler(this.tvFolder_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "file explorer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "expand";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 542);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "collapse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(155, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 47);
            this.button3.TabIndex = 4;
            this.button3.Text = "expand all\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(155, 542);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 47);
            this.button4.TabIndex = 5;
            this.button4.Text = "collapse all";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(457, 477);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 47);
            this.button5.TabIndex = 6;
            this.button5.Text = "add node";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(313, 542);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 47);
            this.button6.TabIndex = 7;
            this.button6.Text = "delete node";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 487);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 26);
            this.textBox1.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(155, 629);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(350, 36);
            this.progressBar1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "check progress";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(309, 638);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(51, 20);
            this.lblPercent.TabIndex = 11;
            this.lblPercent.Text = "label3";
            // 
            // frmSimpleFileExplorer
            // 
            this.AcceptButton = this.button5;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 695);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvFolder);
            this.Name = "frmSimpleFileExplorer";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imglMain;
        private System.Windows.Forms.TreeView tvFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPercent;
    }
}