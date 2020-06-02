using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_list_S
{
    class ContactList
    {
        public List<Contact> Contacts{ get; private set; } = new List<Contact>();
        public string Owner { get; private set; }

        public static ContactList Current
        {
            get
            {
                current ??= new ContactList();
                return current;
            }
            private set
            {
                current = value;
            }
        }

        private static ContactList current;

        public ContactList(string owner)
        {
            Owner = owner;
        }
        public ContactList() { }
        public void NumberOfContacts()
        {
            var a = this.Contacts.Count;
        }
        public void InfoPrint()
        {
            Console.Write($"{Owner}");
        }
    }
}
