using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_list_S
{
    class ContactList
    {
        public List<Contact> Contacts{ get; set; } = new List<Contact>();
        public string Owner { get; private set; }

        public ContactList(string owner)
        {
            Owner = owner;
        }
        
        public void NumberOfContacts()
        {
            var a = this.Contacts.Count;
        }
        public void InfoPrint()
        {
            Console.Write($"{Owner}");
        }

        public Contact this[int index]
        {
            get
            {
                return Contacts[index];
            }
            set
            {
                Contacts[index] = value;
            }
        }
    }
}
