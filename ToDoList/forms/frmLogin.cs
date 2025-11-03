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
    public partial class frmLogin : frmBase
    {
        public frmLogin()
        {
            this.TitleText = "Login Screen";
            InitializeComponent();
            this.ControlBox = false;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (clsUser.CheckUserPassword(txtUserName.Text, txtPassword.Text))
            {
                MessageBox.Show("seccussfully");
            }
            else
            {
                MessageBox.Show("fuck you");
            }
        }

        
        private void lblDontHaveAccount_Click(object sender, EventArgs e)
        {
            Form SignUpScreen = new frmSignup();
            SignUpScreen.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
