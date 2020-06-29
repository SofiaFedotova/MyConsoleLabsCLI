using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_list_S.Tasks
{
    class PrintAllTasks : ITask
    {
        public void Do()
        {
            if (Process.uzing.Contacts == null) { 
                Console.WriteLine($"Empty ContacList by:");
                Process.uzing.InfoPrint(); }
            foreach (Contact c in Process.uzing.Contacts)
            {
                Console.WriteLine($"Name:{c.Name} Surname: {c.Surname} Number: {c.PhoneNumber} Email {c.Email}\n");
            }
        }
    }
}

