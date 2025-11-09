using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ToDoList.business_logic
{
    
    internal static class clsGlobal
    {
        public static string UsersFilePath = "Users.txt";
        public static char Separator = '|';
        public static string TaskFolderPath = "UserTasks";

        public static clsUser CurrentUser = null;

        public static void createfileUser()
        {
            string path = Path.Combine(TaskFolderPath, "q_tasks.txt");
            File.WriteAllText(path, "hello world");
        }
    }
}
