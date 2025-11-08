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

        public static clsUser CurrentUser = null;

        public static void createfileUser()
        {
            File.WriteAllText(UsersFilePath, "user1|1234");
        }
    }
}
