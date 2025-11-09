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
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmBackground());
            //Application.Run(new frmAddTask());
        }
    }
}

// make global task for every one
// THERE IS ERROR WHEN ADDING NEW USER, THEN THE PROBLEM ARE GO OUT
