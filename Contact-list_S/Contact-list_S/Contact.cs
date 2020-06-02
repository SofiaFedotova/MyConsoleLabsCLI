using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_list_S
{
    class Contact
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public Int64 PhoneNumber { get; private set; }
        public string Email { get; private set; }

        public Contact(string name, string surname, Int64 phonenumber, string email)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phonenumber;
            Email = email;
        }
        public Contact(string name, string surname, Int64 phonenumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phonenumber;
            Email = null;
        }
        public Contact(string name,  Int64 phonenumber)
        {
            Name = name;
            Surname = null;
            PhoneNumber = phonenumber;
            Email = null;
        }
        
    }
}
