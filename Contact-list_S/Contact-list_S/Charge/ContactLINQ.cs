using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Xml.Linq;

namespace Contact_list_S.Charge
{
    class ContactLINQ : IStorage
    {
      public void saveList()
        {
            Console.WriteLine("Path:");
            string path = Console.ReadLine().Trim();

            XDocument xDoc = new XDocument();
            XElement xRoot = new XElement("ContactList");
            xDoc.Add(xRoot);
            foreach (Contact c in Process.uzing.Contacts)
            {
                XElement a = new XElement("contact",
                              new XElement("Contact",
                                  new XElement("Name", c.Name),
                                  new XElement("Phone", c.PhoneNumber),
                                  new XElement("Surname", c.Surname),
                                  new XElement("Email", c.Email)) );
                xRoot.Add(a);
                                  }
            
       
            xDoc.Save(path);
        }
       public void openList()
        {
            Console.WriteLine("Path:");
            var Contacts = new List<Contact>();
            string path = Console.ReadLine().Trim();

            string surname = null, name = null, email = null;
            long number = 0;
            XDocument doc = XDocument.Load(path);
            foreach (XElement el in doc.Root.Elements())
            {
                if (el.Name == "name")
                {
                    name = el.Value;
                }
                if (el.Name == "surname")
                {
                    surname = el.Value;
                }

                if (el.Name == "number")
                {
                    number = Int64.Parse(el.Value);
                }
                if (el.Name == "email")
                {
                    email = el.Value; ;
                }
                Contacts.Add(new Contact(name, surname, number, email));
            }

            foreach (Contact c in Contacts)
                Process.uzing.Contacts.Add(c);

        
        }
    }
}
