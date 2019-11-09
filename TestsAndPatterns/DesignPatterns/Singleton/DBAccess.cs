using System;
using System.Collections.Generic;
using System.Text;

namespace TestsAndPatterns.DesignPatterns.Singleton
{
    public sealed class DBAccess // publiczna nie dziedziczona
    {
        // statyczna instancja 
        public static DBAccess _instance;

        // prywatny konstruktor
        private DBAccess() { }

        //dostęp do instancji
        public static DBAccess Istance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DBAccess();
                }
                return _instance;
            }
        }

        // metoda
        public void PrintDBConectionData()
        {
            Console.WriteLine("Database conection data: "+DBConectonData);
        }

        //prop
        public string DBConectonData { get; set; }
    }
}
