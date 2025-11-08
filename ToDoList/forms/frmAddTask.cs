using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList.forms
{
    public partial class frmAddTask : frmBase
    {
        private TreeView _TreevTask;
        private TreeNode _selectedNode;

        public frmAddTask(TreeView MainTreeView, TreeNode selectedNode)
        {
            this.TitleText = "Add Task Screen";
            this.SubTitleText = "";

            _TreevTask = MainTreeView;
            _selectedNode = selectedNode;

            InitializeComponent();

        }

        public frmAddTask()
        {   
            InitializeComponent();
        }

        private bool isCatagoryExist(string catagoryName)
        {
            foreach (var item in cbCategoryTask.Items)
            {
                if (catagoryName == item.ToString())
                {
                    return true;
                }
            }

            return false;
        }

        private bool AddNewCatagory()
        {
            if (cbCategoryTask.SelectedIndex != 0 || isCatagoryExist(txtCatagoryName.Text))
                return false;

            _TreevTask.Nodes.Add(txtCatagoryName.Text, txtCatagoryName.Text, cbCatagoryImage.SelectedIndex, cbCatagoryImage.SelectedIndex);
            return true;
        }


        private TreeNode GetCatarotyNodeByName(string catagoryName)
        {
            foreach (TreeNode node in _TreevTask.Nodes)
            {
                if (node.Text == catagoryName)
                    return node;
            }

            return null; // this is big problem
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (txtCatagoryName.Text == "" || txtTaskName.Text == "")
            {
                MessageBox.Show("catagory name  or  task name is empty");
                return;
            }
            
            AddNewCatagory();
         
            TreeNode CatarotyNode = GetCatarotyNodeByName(txtCatagoryName.Text);

            CatarotyNode.Nodes.Add(txtTaskName.Text, txtTaskName.Text, cbTaskMode.SelectedIndex + 7, cbTaskMode.SelectedIndex + 7); // imageindex = -1, means NONE

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCatagoryNames()
        {
            // add all root node in treeview
            foreach (TreeNode node in _TreevTask.Nodes)
            {
                cbCategoryTask.Items.Add(node.Text);
            }
        }

        private void SelectCurrentCatagory()
        {
            // if not selected -> new
            // else get the select catagory
            
            cbCategoryTask.SelectedItem = "New";
            
            if (_selectedNode != null)
            {
                foreach (var item in cbCategoryTask.Items)
                {
                    if (item.ToString() == _selectedNode.Text)
                    {
                        cbCategoryTask.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void EnableDisableNewCatagory()
        {
            if (cbCategoryTask.SelectedIndex != 0)
            {
                txtCatagoryName.Enabled = false;
                cbCatagoryImage.Enabled = false;
            }
            else
            {
                txtCatagoryName.Enabled = true;
                cbCatagoryImage.Enabled = true;
            }

        }

        private void UpdateNewCatagoryControls()
        {
            if (cbCategoryTask.SelectedIndex != 0)
            {
                txtCatagoryName.Text = cbCategoryTask.Text;
                cbCatagoryImage.SelectedIndex = GetCatarotyNodeByName(cbCategoryTask.Text).ImageIndex;
            }
            else
            {
                txtCatagoryName.Text = "";
                cbCatagoryImage.SelectedIndex = 0;
            }
        }


        private void frmAddTask_Load(object sender, EventArgs e)
        {
            LoadCatagoryNames();

            SelectCurrentCatagory();

            EnableDisableNewCatagory(); // update control

            cbTaskMode.SelectedIndex = 0;
        }

        private void cbCategoryTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableDisableNewCatagory();
            UpdateNewCatagoryControls();
        }

        private void cbCatagoryImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbGatagoryImage.Image = imageListCatagory.Images[cbCatagoryImage.SelectedIndex];
        }

        private void cbTaskMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbTaskMode.Image = imageListCatagory.Images[cbTaskMode.SelectedIndex + 7];
        }
    }
}
