using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

/*
 * 
 * in file the order of Node
 * 
 * catagory
 * -1 | node index | key | text | imageIndex | selectedImageIndex | check 
 * 
 * task 
 * parent node index | node index | key | text | imageIndex | selectedImageIndex | check 
 */

namespace ToDoList.business_logic
{
    internal static class clsTask
    {

        private static string getTaskFilePath(string username)
        {
            return Path.Combine(clsGlobal.TaskFolderPath, $"{username}_tasks.txt");
        }

        private static string getDataLineNode(TreeNode node, int nodeIndex, bool isCatagory, int parentNodeIndex = -1)
        {
            string line = "";

            line += (isCatagory ? "-1" : parentNodeIndex.ToString()) + clsGlobal.Separator;
            line += nodeIndex.ToString() + clsGlobal.Separator;
            line += node.Name + clsGlobal.Separator;
            line += node.Text + clsGlobal.Separator;
            line += node.ImageIndex.ToString() + clsGlobal.Separator;
            line += node.SelectedImageIndex.ToString() + clsGlobal.Separator;
            line += node.Checked.ToString();

            return line;
        }

        public static void SaveTasksToFile(TreeView treevTask, string username)
        {
            string path = getTaskFilePath(username);
            string dataLine = "";

            List <TreeNode> catagoryNodes = new List<TreeNode>();

            File.WriteAllText(path, string.Empty); // open file and reset file

            using (StreamWriter sw = new StreamWriter(path, append: true))
            {
                // first store catagory
                for (int i = 0; i < treevTask.Nodes.Count; i++)
                {
                    catagoryNodes.Add(treevTask.Nodes[i]);

                    dataLine = getDataLineNode(treevTask.Nodes[i], i, true);

                    sw.WriteLine(dataLine);
                }
                
                // second store tasks
                for (int i = 0; i < catagoryNodes.Count; i++)
                {
                    for (int j = 0; j < catagoryNodes[i].Nodes.Count; j++)
                    {
                        dataLine = getDataLineNode(catagoryNodes[i].Nodes[j], j, false, i);

                        sw.WriteLine(dataLine);
                    }
                }
            }
        }

        private static bool isCatagoryByIndex(string indexText)
        {
            int.TryParse(indexText, out int result);
            return result == -1;
        }

        private static void AddCatagory(TreeView tree, string[] data)
        {
            int.TryParse(data[1], out int nodeIndex);
            int.TryParse(data[4], out int imageIndex);
            int.TryParse(data[5], out int selectedImageIndex);
            bool.TryParse(data[6], out bool checkedStatus);

            tree.Nodes.Insert(nodeIndex, data[2], data[3], imageIndex, selectedImageIndex);
            tree.Nodes[nodeIndex].Checked = checkedStatus;
        }

        private static void AddTask(TreeView tree, string[] data)
        {
            int.TryParse(data[0], out int catagoryIndex);
            int.TryParse(data[1], out int nodeIndex);
            int.TryParse(data[4], out int imageIndex);
            int.TryParse(data[5], out int selectedImageIndex);
            bool.TryParse(data[6], out bool checkedStatus);

            tree.Nodes[catagoryIndex].Nodes.Insert(nodeIndex, data[2], data[3], imageIndex, selectedImageIndex);
            tree.Nodes[catagoryIndex].Nodes[nodeIndex].Checked = checkedStatus;
        }

        public static void LoadTasksFromFile(TreeView treevTask, ImageList imagelist, string username)
        {
            string path = getTaskFilePath(username);

            using (StreamReader reader = new StreamReader(path))
            {
                string dataLine = "";

                while ((dataLine = reader.ReadLine()) != null)
                {
                    string[] data = dataLine.Split(clsGlobal.Separator);

                    if (isCatagoryByIndex(data[0]))
                    {
                        AddCatagory(treevTask, data);
                    }
                    else
                    {
                        AddTask(treevTask, data);
                    }
                }
            }
        }

    }
}
