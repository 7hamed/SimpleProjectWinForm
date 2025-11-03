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
    public partial class frmBase : Form
    {
        protected string TitleText
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        protected string SubTitleText
        {
            get { return lblSubTitle.Text; }
            set { lblSubTitle.Text = value; }
        }

        public frmBase()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.CenterToScreen();
        }

    }
}
