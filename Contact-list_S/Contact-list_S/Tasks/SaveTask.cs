using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact_list_S.Charge;

namespace Contact_list_S.Tasks
{
    class SaveTask: ITask
    {
        public void Do()
        {
            try
            {
                GlobalCharging.Storage.saveList();
                Process.ColorfulWrite("Saved!", ConsoleColor.DarkMagenta);
            }
            catch (Exception)
            {
                Process.ColorfulWrite("SomethingOccured!", ConsoleColor.DarkRed);
                throw new EntryPointNotFoundException();
            }
        }
    }
}
