using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_list_S.Tasks
{
    class HelpTask : ITask
    {
        public void Do()
        {
            Console.Write("Menu \n 'add' - to add contact \n 'change' to change contact \n 'search' \n  'printall' - to print all contacts \n 'clear' \n 'exit' \n 'help' to view information \n 'open' to open you existing list \n 'save' - to save current list ");
        }
    }
}
