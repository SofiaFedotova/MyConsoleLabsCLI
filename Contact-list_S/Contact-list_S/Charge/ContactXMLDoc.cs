using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Contact_list_S.Charge
{
    class ContactXMLDoc : IStorage
    {
        public void saveList()
        {
            Console.WriteLine("Path:");
            string path = Console.ReadLine().Trim();
            
            XmlDocument xDoc = new XmlDocument();
            
            var xRoot = xDoc.CreateElement("ContactList");
            xDoc.AppendChild(xRoot);
            foreach (Contact c in Process.uzing.Contacts)
            {
                XmlElement xnode = xDoc.CreateElement("xnode");
                XmlElement name = xDoc.CreateElement("name");
                XmlElement surname = xDoc.CreateElement("surname");
                XmlElement number = xDoc.CreateElement("number");
                XmlElement email = xDoc.CreateElement("email");
                XmlText nameT = xDoc.CreateTextNode(c.Name);
                XmlText surnameT = xDoc.CreateTextNode(c.Surname);
                XmlText emailT = xDoc.CreateTextNode(c.Email);
                XmlText numberT = xDoc.CreateTextNode(c.PhoneNumber.ToString());
                xRoot.AppendChild(xnode);
                xnode.AppendChild(name);
                xnode.AppendChild(surname);
                xnode.AppendChild(email);
                xnode.AppendChild(number);
                name.AppendChild(nameT);
                surname.AppendChild(surnameT);
                email.AppendChild(emailT);
                number.AppendChild(numberT);
            }
            xDoc.Save(path);
        }
            





        public void openList()
        {
            Console.WriteLine("Path:");
            string path = Console.ReadLine().Trim();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            XmlElement xRoot = xDoc.DocumentElement;
            Process.CreateList(path);

            var Contacts = new List<Contact>();

            foreach (XmlNode xnode in xRoot)
            {
                string surname = null, name = null, email = null;
                long number = 0;
                foreach (XmlNode childnode in xnode.ChildNodes)
                {

                    if (childnode.Name == "name")
                    {
                        name = childnode.InnerText;
                    }
                    if (childnode.Name == "surname")
                    {
                        surname = childnode.InnerText;
                    }

                    if (childnode.Name == "number")
                    {
                        number = Int64.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "email")
                    {
                        email = childnode.InnerText;
                    }

                }
                Contacts.Add(new Contact(name, surname, number, email));
            }

            foreach (Contact c in Contacts)
                Process.uzing.Contacts.Add(c);
        }
    }
}
