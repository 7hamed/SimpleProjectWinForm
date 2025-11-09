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
    public partial class frmSignup : frmBase
    {
        public frmSignup()
        {
            this.TitleText = "Sign In Screen";
            this.SubTitleText = "";
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)
                || string.IsNullOrWhiteSpace(txtRepeatPassword.Text))
            {
                MessageBox.Show("UsernName or Password is empty.\nPlease write then correctly.");
                txtUserName.Focus();
                return;
            }
            
            if (clsUser.getUserByUserName(txtUserName.Text) != null)
            {
                MessageBox.Show("user name is already exist");
                txtUserName.Focus();
                return;
            }

            if (txtPassword.Text != txtRepeatPassword.Text)
            {
                MessageBox.Show("password should to be same");
                txtRepeatPassword.Focus();
                return;
            }

            clsUser.AddUser(txtUserName.Text, txtPassword.Text);
            MessageBox.Show("user added");
            return;
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Form LoginScreen = new frmLogin();
            LoginScreen.Show();
            this.Close();
        }
    }
}
