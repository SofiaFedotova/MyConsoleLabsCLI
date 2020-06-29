using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_list_S.Tasks
{
    class ChangeTaskcs : ITask
    {
        public void Do()
        {
            SearchTask search = new SearchTask();
            int index = search.IndexSearched();
            if (index == -1)
                Console.WriteLine("No element found");
            else
            {
                string resultname, resultsurname, resultemail;
                string changes;
                long resultnumber;
                Console.WriteLine("Name:(type 0 if you dont want to change this field");
                changes = Console.ReadLine().Trim();
                if (changes == "0" || changes == null)
                    resultname = Process.uzing.Contacts[index].Name;
                else
                    resultname = changes;


                Console.WriteLine("Surname:(type 0 if you dont want to change this field");
                changes = Console.ReadLine().Trim();
                if (changes == "0" || changes == null)
                    resultsurname = Process.uzing.Contacts[index].Surname;
                else
                    resultsurname = changes;

                Console.WriteLine("Email:(type 0 if you dont want to change this field");
                changes = Console.ReadLine().Trim();
                if (changes == "0" || changes == null)
                    resultemail = Process.uzing.Contacts[index].Email;
                else
                    resultemail = changes;

                Console.WriteLine("Number:(type 0 if you dont want to change this field");
                changes = Console.ReadLine().Trim();
                if (changes == "0" || changes == null)
                    resultnumber = Process.uzing.Contacts[index].PhoneNumber;
                else
                    resultnumber = Int64.Parse(changes);
                Process.uzing.Contacts.RemoveAt(index);
                Process.uzing.Contacts.Add(new Contact(resultname, resultsurname, resultnumber, resultemail));

                Console.WriteLine("Was updated");
            }

        }
    }
}
