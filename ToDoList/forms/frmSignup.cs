using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private string GetTaskFilePath(string username)
        {
            return Path.Combine(clsGlobal.TaskFolderPath, $"{username}_tasks.txt");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("UserName or Password is empty.\nPlease write them correctly.");
                txtUserName.Focus();
                return;
            }

            if (txtUserName.Text.Contains(clsGlobal.Separator) || txtPassword.Text.Contains(clsGlobal.Separator))
            {
                MessageBox.Show($"UserName or Password contains {clsGlobal.Separator} \nPlease Dont use it.");
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
            File.Create(GetTaskFilePath(txtUserName.Text)).Close(); // create empty file for tasks
            MessageBox.Show("user added");
            return;
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Form LoginScreen = new frmLogin();
            LoginScreen.Show();
            this.Close();
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (TextNullOrWhiteSpacesErrorProvider((Guna2TextBox)sender, "username cant be empty"))
                return;

            if (TextContainsCharErrorProvider((Guna2TextBox)sender, $"username cant contains {clsGlobal.Separator} ", clsGlobal.Separator))
                return;
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (TextNullOrWhiteSpacesErrorProvider((Guna2TextBox)sender, "password cant be empty"))
                return;

            if (TextContainsCharErrorProvider((Guna2TextBox)sender, $"password cant contains {clsGlobal.Separator} ", clsGlobal.Separator))
                return;
        }
    }
}
