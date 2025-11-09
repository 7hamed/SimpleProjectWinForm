using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.business_logic;

namespace ToDoList.forms
{
    public partial class frmMain : frmBase
    {
        public frmMain()
        {
            this.TitleText = "Main Screen";
            this.SubTitleText = "user name : " + clsGlobal.CurrentUser.UserName;
            this.ControlBox = false;
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form LoginScreen = new frmLogin();
            LoginScreen.Show();
            this.Close();
        }


        private bool DeleteTask(TreeNode task)
        {
            treevTask.Nodes.Remove(task);
            return true;
        }

        private bool DeleteSelectedTask()
        {
            return DeleteTask(treevTask.SelectedNode);
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (treevTask.SelectedNode == null)
            {
                MessageBox.Show("you dont select any task");
                return;
            }

            foreach (TreeNode node in treevTask.Nodes)
            {
                if (node == treevTask.SelectedNode)
                {
                    var answer = MessageBox.Show("are you sure to delete This catagory with all tasks", "confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (answer == DialogResult.OK)
                    {
                        DeleteSelectedTask();
                        return;
                    }
                    else
                        return;
                } 
            }

            DeleteSelectedTask();
        }

        private void tsmUpdate_Click(object sender, EventArgs e)
        {
            if (treevTask.SelectedNode == null)
            {
                MessageBox.Show("you dont select any task");
                return;
            }

            Form UpdateTaskScreen = new frmUpdateTask(treevTask, treevTask.SelectedNode);
            UpdateTaskScreen.ShowDialog();
        }

        private void CheckTask(TreeNode node, bool checkedStatus)
        {
            node.Checked = checkedStatus;

            if (checkedStatus)
                node.BackColor = Color.LightGreen;
            else
                node.BackColor = Color.White;

        }

        private void CheckAllChild(TreeNode node, bool checkedStatus)
        {
            foreach (TreeNode n in node.Nodes)
            {
                CheckTask(n, checkedStatus);
            }
        }

        private void treevTask_AfterCheck(object sender, TreeViewEventArgs e)
        {
            treevTask.AfterCheck -= treevTask_AfterCheck;

            CheckTask(e.Node, e.Node.Checked);
            CheckAllChild(e.Node, e.Node.Checked);

            treevTask.AfterCheck += treevTask_AfterCheck;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Form AddNewTaskScreen = new frmAddTask(treevTask, treevTask.SelectedNode);
            AddNewTaskScreen.ShowDialog();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            treevTask.SelectedNode = null;
            treevTask.Focus();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            clsTask.SaveTasksToFile(treevTask, clsGlobal.CurrentUser.UserName);
        }

        private void ExpandNodes(TreeNode root)
        {
            root.Expand();

            if (root.Nodes.Count > 0)
            {
                foreach (TreeNode node in root.Nodes)
                {
                    ExpandNodes(node);
                }
            }
        }

        private void ExpandTreeView(TreeView treeview)
        {
            foreach (TreeNode node in treeview.Nodes)
            {
                ExpandNodes(node);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            treevTask.Nodes.Clear();
            clsTask.LoadTasksFromFile(treevTask, imageListCatagory, clsGlobal.CurrentUser.UserName);

            ExpandTreeView(treevTask);
        }
    }
}
