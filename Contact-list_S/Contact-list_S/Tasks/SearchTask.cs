using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_list_S.Tasks
{
    class SearchTask : ITask
    {
        delegate int Search();
        public static int Index;
        public  void Do()
        {
            
            Search s = Default;
            int index = -1;
            while (s == Default) {
                Console.WriteLine("Search by:  ('name', 'surname', 'number', 'email'");
                var str = Console.ReadLine().Trim();
                if (str == "name")
                    s = NameSearch;
                if (str == "surname")
                    s = SurnameSearch;
                if (str == "number")
                    s = NumberSearch;
                if (str == "email")
                    s = EmailSearch;
                index = s();
            }
            Index = index;
            if (index == -1)
                Console.WriteLine($"Nothing Found\n");
            else
               Console.WriteLine($"This contact was found {Process.uzing.Contacts[index].Name} \n {Process.uzing.Contacts[index].Surname} \n {Process.uzing.Contacts[index].Email} \n ");
        }
        public int IndexSearched() {
            Do();
            return Index;
        }

        int Default() { Console.WriteLine("No such a tag found"); return 0; }
        int NumberSearch() { { Console.WriteLine("Name"); return Process.uzing.Contacts.FindIndex(c => c.Name == Console.ReadLine().Trim()); } }
        int NameSearch() {
            Console.WriteLine("Name");
            string str = Console.ReadLine().Trim();
            if (str != null)
                 { return Process.uzing.Contacts.FindIndex(c => c.Name == str); }
            else 
                return -1;
        }
        int EmailSearch()
        {
            Console.WriteLine("Email");
            string str = Console.ReadLine().Trim();
            if (str != null)
            { return Process.uzing.Contacts.FindIndex(c => c.Email == str); }
            else
                return -1;
        }
        int SurnameSearch()
        {
            Console.WriteLine("Surame");
            string str = Console.ReadLine().Trim();
            if (str != null)
            { return Process.uzing.Contacts.FindIndex(c => c.Surname == str); }
            else
                return -1;
        }

    }
}
