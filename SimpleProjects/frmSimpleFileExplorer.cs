using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_testForms
{
    public partial class frmSimpleFileExplorer : Form
    {
        public frmSimpleFileExplorer()
        {
            InitializeComponent();
        }

        private void tvFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.Text = tvFolder.SelectedNode.Text;
        }

        private void tvFolder_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(tvFolder.SelectedNode.Text, "Object Name");
        }

        private void checkTheNode(TreeNode node, bool checkedStatus)
        {
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = checkedStatus;

                if (item.Nodes.Count > 0)
                {
                    checkTheNode(item, checkedStatus);
                }
            }
        }

        private void tvFolder_AfterCheck(object sender, TreeViewEventArgs e)
        {
            checkTheNode(e.Node, e.Node.Checked);
            updateProgressBar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tvFolder.SelectedNode.Expand();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tvFolder.SelectedNode.Collapse();
        }

       
       

        private void expandAllNodes(TreeNode root)
        {
            root.Expand();
            
            foreach (TreeNode node in root.Nodes)
            {
                node.Expand();

                if (node.Nodes.Count > 0)
                {
                    expandAllNodes(node);
                }
            }
        }


        private void collapseAllNodes(TreeNode root)
        {
            root.Collapse();
            
            foreach (TreeNode node in root.Nodes)
            {
                node.Collapse();

                if (node.Nodes.Count > 0)
                {
                    collapseAllNodes(node);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in tvFolder.Nodes)
            {
                expandAllNodes(node);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in tvFolder.Nodes)
            {
                collapseAllNodes(node);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (tvFolder.SelectedNode == null)
                {
                    tvFolder.Nodes.Add(textBox1.Text);
                }
                else
                { 
                    tvFolder.SelectedNode.Nodes.Add(textBox1.Text);
                }

                updateProgressBar();
                textBox1.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tvFolder.Nodes.Count > 0)
            {
                tvFolder.SelectedNode.Remove();
                updateProgressBar();
            }
            else
            {
                MessageBox.Show("there is no node to delete");
            }
        }

        private int getNodeNumberOfTreeView(TreeView tv)
        {
            int count = 0;
            
            foreach (TreeNode node in tv.Nodes)
            {
                count += getChildNumber(node);
            }

            return count;
        }

        private int getChildNumber(TreeNode root)
        {
            int count = 0;

            foreach (TreeNode node in root.Nodes)
            {
                if (node.Nodes.Count == 0)
                    count++;
                else
                    count += getChildNumber(node);
            
            }

            return count;
        }


        private int getCheckedChildNumber(TreeNode root)
        {
            int count = 0;

            foreach (TreeNode node in root.Nodes)
            {
                if (node.Nodes.Count == 0 && node.Checked)
                    count++;
                else
                    count += getCheckedChildNumber(node);
            }

            return count;
        }

        private int getCheckedNodeNumbersOfTreeView(TreeView tv)
        {
            int count = 0;
            
            foreach (TreeNode node in tv.Nodes)
            {
                count += getCheckedChildNumber(node);
            }

            return count;
        }

        private void updateProgressBar()
        {
            progressBar1.Maximum = getNodeNumberOfTreeView(tvFolder);
            progressBar1.Value = getCheckedNodeNumbersOfTreeView(tvFolder);

            lblPercent.Text = $"{(float)progressBar1.Value / progressBar1.Maximum * 100:F1}";
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            lblPercent.BackColor = Color.Transparent;
            updateProgressBar();

        }
    }
}
