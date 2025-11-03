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
            this.SubTitleText = "user name : " + _getUserNameOfCurrentUser();
            this.ControlBox = false;
            InitializeComponent();
        }

        private string _getUserNameOfCurrentUser()
        {
            return clsUser.getLastCorrectUser().UserName;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form LoginScreen = new frmLogin();
            LoginScreen.Show();
            this.Close();
        }
    }
}
