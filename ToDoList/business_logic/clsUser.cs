using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.business_logic
{
    internal class clsUser
    {

        public string UserName { get; set; }
        public string Password { get; set; }

        public clsUser(string username, string passowrd)
        {
            UserName = username;
            Password = passowrd;
        }

        private static clsUser _ConvertLineToUser(string line)
        {
            string[] data = line.Split(clsGlobal.Separator);

            return new clsUser(data[0], data[1]);
        }

        public static clsUser getUserByUserName(string username)
        {
            using (StreamReader reader = new StreamReader(clsGlobal.UsersFilePath))
            {
                string line;
                clsUser tempUser = null;
                while ((line = reader.ReadLine()) != null)
                {
                    tempUser = _ConvertLineToUser(line);

                    if (tempUser.UserName == username)
                        return tempUser;

                }
            }

            return null;
        }

        public static bool CheckUserPassword(clsUser user, string password)
        {
            return user.Password == password;
        }

        public static bool loginUser(string username, string password)
        {
            clsUser user = getUserByUserName(username);

            if (user == null) 
                return false;

            if (CheckUserPassword(user, password))
            {
                clsGlobal.CurrentUser = user;
                return true;
            }
            else
                return false;
        }


        public static void AddUser(string username, string password)
        {
            using (StreamWriter sw = new StreamWriter(clsGlobal.UsersFilePath, append: true))
            {
                sw.WriteLine($"{username}|{password}");   // adds newline automatically
            }

        }

    }
}
