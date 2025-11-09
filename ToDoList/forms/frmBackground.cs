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
    public partial class frmBackground : Form
    {
        public frmBackground()
        {
            InitializeComponent();
        }

        public static Form CurrentForm = new frmLogin();

        private void frmBackground_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.ShowInTaskbar = false;

            CurrentForm.Show();
        }
    }
}
