using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList;
using ToDoList.forms;

namespace ToDoList
{
    internal static class Program
    {
        
        public enum eNextForm { Exit, Login, Signup, Main}
        public static eNextForm NextForm = eNextForm.Login;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmBackground());

        }
    }
}
