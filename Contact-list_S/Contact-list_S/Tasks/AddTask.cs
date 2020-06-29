using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_list_S.Tasks
{
    class AddTask : ITask
    {
        public void Do()
        {
            Console.WriteLine("Name:");
            string Name = Console.ReadLine().Trim();
            Console.WriteLine("Surname:");
            string Surname = Console.ReadLine().Trim();
            Console.WriteLine("Number:");
            long Number = Int64.Parse(Console.ReadLine());
            Console.WriteLine("Email:");
            string Email = Console.ReadLine().Trim();

            Process.uzing.Contacts.Add(new Contact(Name, Surname, Number, Email));
            Console.WriteLine("Succesfully added Contact");
        }
    }
}
