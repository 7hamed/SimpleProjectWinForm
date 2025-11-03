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
    public partial class frmSignup : frmBase
    {
        public frmSignup()
        {
            this.TitleText = "Sign In Screen";
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (clsUser.isUserExist(txtUserName.Text) != null)
            {
                MessageBox.Show("fuck user name");
                return;
            }

            if (txtPassword.Text != txtRepeatPassword.Text)
            {
                MessageBox.Show("fuck password not same");
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
