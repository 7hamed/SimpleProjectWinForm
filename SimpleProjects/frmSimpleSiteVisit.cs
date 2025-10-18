using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_testForms
{
    public partial class frmSimpleSiteVisit : Form
    {
        public frmSimpleSiteVisit()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString().ToLower())
            {
                case "youtube":
                    linkLabel1.Text = "YouTube";
                    linkLabel1.Tag = "https://www.youtube.com";
                    break;

                case "facebook":
                    linkLabel1.Text = "FaceBook";
                    linkLabel1.Tag = "https://www.facebook.com";
                    break;

                case "programming advices":
                    linkLabel1.Text = "Porgramming Advices";
                    linkLabel1.Tag = "https://programmingadvices.com/";
                    break;
            }

            linkLabel1.LinkVisited = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(linkLabel1.Tag.ToString());
        }
    }
}
