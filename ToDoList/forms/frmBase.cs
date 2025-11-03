using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class frmBase : Form
    {
        protected string TitleText
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public frmBase()
        {
            InitializeComponent();
        }
    }
}
