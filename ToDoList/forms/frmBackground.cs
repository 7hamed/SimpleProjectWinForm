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
using System.Xml.Serialization;
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

        private static void CreateUserFileIfNotExist()
        {
            if (!File.Exists(clsGlobal.UsersFilePath))
            {
                File.Create(clsGlobal.UsersFilePath).Close();
            }
        }

        private static void CreateTasksFolderIfNotExist()
        {
            if (!Directory.Exists(clsGlobal.TaskFolderPath))
            {
                Directory.CreateDirectory(clsGlobal.TaskFolderPath);
            }
        }

        private void frmBackground_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.ShowInTaskbar = false;

            CreateUserFileIfNotExist();
            CreateTasksFolderIfNotExist();

            CurrentForm.Show();
        }
    }
}
