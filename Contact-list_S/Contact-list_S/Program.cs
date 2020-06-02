using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_list_S
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactList l = new ContactList("Вася");
            l.InfoPrint();
        }
       
    }
}
