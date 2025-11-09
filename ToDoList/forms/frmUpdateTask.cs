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
    public partial class frmUpdateTask : frmBase
    {
        private TreeView _treevTask;
        private TreeNode _selectedTask;
        private bool _isGatagory;

        private bool isGatagory()
        {
            foreach (var node in _treevTask.Nodes)
            {
                if (node == _selectedTask)
                {
                    return true;
                }
            }

            return false;
        }

        public frmUpdateTask(TreeView MainTreeView, TreeNode selectedNode)
        {
            _treevTask = MainTreeView;
            _selectedTask = selectedNode;
            _isGatagory = isGatagory();

            string updatetype = _isGatagory ? "Catagory" : "Task";
            this.TitleText = $"Update {updatetype} Screen";
            this.SubTitleText = $"selected task : \"{selectedNode.Text}\"";

            InitializeComponent();
        }

        public frmUpdateTask()
        {
            InitializeComponent();
        }

        private bool isGatagoryExist(string catagoryName)
        {
            foreach (TreeNode node in _treevTask.Nodes)
            {
                if (node.Text == catagoryName)
                    return true;
            }

            return false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewName.Text))
            {
                MessageBox.Show("New Name is Empty, please enter valide name");
                return;
            }
            
            if (_isGatagory && _selectedTask.Text != txtNewName.Text)
            {
                if (isGatagoryExist(txtNewName.Text))
                {
                    MessageBox.Show("this catagory is exist, please change it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewName.Focus();
                    return;
                }
            }
            
            _selectedTask.Text = txtNewName.Text;

            if (_isGatagory)
            {
                _selectedTask.ImageIndex = cbCatagoryImage.SelectedIndex;
                _selectedTask.SelectedImageIndex = cbCatagoryImage.SelectedIndex;
            }
            else
            {
                _selectedTask.ImageIndex = cbTaskMode.SelectedIndex + 7;
                _selectedTask.SelectedImageIndex = cbTaskMode.SelectedIndex + 7;
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SwitchComboBox(bool isCatagory)
        {
            if (isCatagory)
            {
                cbCatagoryImage.Visible = true;
                cbCatagoryImage.BringToFront();

                cbTaskMode.Visible = false;
            }
            else
            {
                cbTaskMode.Visible = true;
                cbTaskMode.BringToFront();

                cbCatagoryImage.Visible = false;
            }
        }

        private void SwitchLabelImageText(bool isCatagory)
        {
            if (isCatagory)
            {
                lblImage.Text = "New Catagory Image";
            }
            else
            {
                lblImage.Text = "New Task Mode";
            }
        }

        private void frmUpdateTask_Load(object sender, EventArgs e) // for initial values of controls
        {
            txtNewName.Text = _selectedTask.Text;

            pbImage.Image = imageListCatagory.Images[_selectedTask.ImageIndex];

            if (_isGatagory)
            {
                cbCatagoryImage.SelectedIndex = _selectedTask.ImageIndex;
            }
            else
            {
                cbTaskMode.SelectedIndex = _selectedTask.ImageIndex - 7;
            }

            SwitchLabelImageText(_isGatagory);
        }

        private void cbCatagoryImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbImage.Image = imageListCatagory.Images[cbCatagoryImage.SelectedIndex];
        }

        private void frmUpdateTask_Shown(object sender, EventArgs e) // for change UI of controls
        {
            SwitchComboBox(_isGatagory); 

        }

        private void cbTaskMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbImage.Image = imageListCatagory.Images[cbTaskMode.SelectedIndex + 7];
        }
    }
}