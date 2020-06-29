using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Contact_list_S.Charge;

namespace Contact_list_S.Tasks
{
    class OpenList : ITask
    {
        public void Do()
        {
            Console.WriteLine("Path:");
            string path = Console.ReadLine().Trim();
            if (path.Length == 0 || !File.Exists(path))
            { Console.WriteLine("No such a file"); throw new Exception("No such a file"); }
            try
            {
                GlobalCharging.Storage.openList();
                Process.ColorfulWrite("Opened!", ConsoleColor.DarkMagenta);
            }
            catch (Exception)
            {
                Process.ColorfulWrite("Something Occured!", ConsoleColor.DarkRed);
            }
        }
    }
}
