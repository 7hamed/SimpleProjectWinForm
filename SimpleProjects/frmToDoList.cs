using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_ToDoList
{
    public partial class frmToDoList : Form
    {
        public frmToDoList()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (btnAddTask.Text == "Edit")
            {
                return;
            }

            if (txtTaskName.Text != "")
            {
                chkbTasks.Items.Add(txtTaskName.Text);
                txtTaskName.Text = "";
            }
            else
            {
                MessageBox.Show("please enter name of the task first");
            }

            UpdateTasksStatus();

        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (chkbTasks.SelectedItem != null)
            {
                chkbTasks.Items.Remove(chkbTasks.SelectedItem);
            }
            else
            {
                MessageBox.Show("there is no selections item...");
            }

            UpdateTasksStatus();

        }

        private void frmToDoList_Click(object sender, EventArgs e)
        {
            chkbTasks.SelectedItem = null;
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (chkbTasks.SelectedItem != null && txtTaskName.Text != "")
            {

                int indexItem = chkbTasks.SelectedIndex;
                bool wasChecked = chkbTasks.GetItemChecked(indexItem);

                chkbTasks.Items[indexItem] = txtTaskName.Text;
                chkbTasks.SetItemChecked(indexItem, wasChecked);

                txtTaskName.Text = "";
            }
            else
            {
                MessageBox.Show("there is no Selected item or Name task is empty");
            }
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkbTasks.Items.Count; i++)
            {
                chkbTasks.SetItemChecked(i, true);
            }
        }

        private void btnUnCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkbTasks.Items.Count; i++)
            {
                chkbTasks.SetItemChecked(i, false);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (chkbTasks.CheckedItems.Count == 0)
            {
                MessageBox.Show("there is no checked items");
            }

            for (int i = 0; i < chkbTasks.CheckedItems.Count; i++)
            {
                MessageBox.Show(chkbTasks.CheckedItems[i].ToString());
            }
        }

        private int getPendingTasks()
        {
            return chkbTasks.Items.Count - chkbTasks.CheckedItems.Count;
        }

        private int getCompletedTasks()
        {
            return chkbTasks.CheckedItems.Count;
        }

        private void UpdateTasksStatus()
        {
            lblPending.Text = getPendingTasks().ToString();
            lblCompleted.Text = getCompletedTasks().ToString();
        }



        private void frmToDoList_Load(object sender, EventArgs e)
        {
            UpdateTasksStatus();

        }

        private void chkbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTasksStatus();
        }


    }
}
