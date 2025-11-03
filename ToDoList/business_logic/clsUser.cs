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

        public static clsUser isUserExist(string username)
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

        public static bool CheckUserPassword(string username, string passowrd)
        {
            clsUser tempuser = isUserExist(username);
            
            if (tempuser == null)
                return false;

            if (tempuser.Password == passowrd)
            {
                clsGlobal.LastCorrectUser = tempuser;
                return true;
            }
            else
                return false;
        }

        
        public static clsUser getLastCorrectUser()
        {
            if (clsGlobal.LastCorrectUser != null)
            {
                return clsGlobal.LastCorrectUser;
            }

            return null;
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
