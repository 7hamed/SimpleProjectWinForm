using Guna.UI2.WinForms;
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
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        protected bool setErrorProvider(Control control, string ErrorMessage)
        {
            ErrpvMain.SetError(control, ErrorMessage);
            return ErrorMessage != "";
        }

        protected bool TextNullOrWhiteSpacesErrorProvider(Guna2TextBox textbox, string ErrorMessage)
        {
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                return setErrorProvider((Control)textbox, ErrorMessage);
            }
            else
            {
                return setErrorProvider((Control)textbox, "");
            }
        }

        protected bool TextContainsCharErrorProvider(Guna2TextBox textbox, string ErrorMessage, char c)
        {
            if (textbox.Text.Contains(c))
            {
                return setErrorProvider((Control)textbox, ErrorMessage);
            }
            else
            {
                return setErrorProvider((Control)textbox, "");
            }
        }

    }
}
