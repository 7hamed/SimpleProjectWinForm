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
            this.SubTitleText = "";
            InitializeComponent();
            this.ControlBox = false;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            //if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            //{
            //    MessageBox.Show("UserName or Password is empty.\nPlease wirte them correctly");
            //    return;
            //}

            if (clsUser.loginUser(txtUserName.Text, txtPassword.Text))
            {
                Form MainScreen = new frmMain();
                MainScreen.Show();
                this.Close();
            }
            else
            {
                var answer = MessageBox.Show("UserName or Password is wrong.\nDo you want to create new account", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                
                if (answer == DialogResult.Yes)
                {
                    lblDontHaveAccount_Click(sender, e);
                }
                else
                {
                    txtUserName.Focus();
                }
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
