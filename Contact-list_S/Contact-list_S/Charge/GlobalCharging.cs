using System;
using System.Configuration;
using System.Collections.Generic;



namespace Contact_list_S.Charge
{
    static class GlobalCharging
    {

        /*public static void ChangeStorageSystem(string storage)
        {
            if (Storages.ContainsKey(storage))
            {
                ConfigurationManager.appSettings["Storage"] = storage;
            }
        }*/
        public static IStorage Storage
        {
            get
            {
                //try
                //{
                    return Storages["XML"];//Storages[ConfigurationManager.appSettings["Storage"]];
                //}
               /* catch (ConfigurationErrorsException)
                {
                    Console.WriteLine("Error reading app settings");
                }*/
            }
        }
        public static readonly Dictionary<string, IStorage> Storages = new Dictionary<string, IStorage>()
        {
            ["XML"] = new ContactXMLDoc(),
            ["XMLSerialization"] = new ContactSerialization(),
            ["LINQ"] = new ContactLINQ()
        };
    }
}


