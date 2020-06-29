using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Contact_list_S.Charge
{
    class ContactSerialization : IStorage
    {
        public void saveList()
        {
            try
            {
                Console.WriteLine("Path:");
                string path = Console.ReadLine().Trim();
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    var serial = new XmlSerializer(typeof(ContactList));
                    
                      serial.Serialize(fs, Process.uzing.Contacts);
                    
                }
            }
            catch(Exception)
            {
                Console.WriteLine($"File Path Exception");
            }
        }
        public void openList()
        {
            try
            {
                Console.WriteLine("Path:");
                string path = Console.ReadLine().Trim();
                using (var stream = new FileStream(path, FileMode.Open))
                using (var reader = XmlReader.Create(stream))
                {
                    var serial = new XmlSerializer(typeof(ContactList));
                    Process.CreateList(path);

                    ContactList contacts = serial.Deserialize(stream) as ContactList;
                    foreach(Contact c in contacts.Contacts)
                    {
                        Process.uzing.Contacts.Add(c);
                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine($"File Path Exception");
            }
        }
    }
}
