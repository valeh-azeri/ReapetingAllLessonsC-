using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForStaticandAthers
{
    public static class Customer
    {
        public static int Id;
        public static string Name;
        public static string Surname;
        private static string Username;
        public static string Password;
        private static ArrayList Customers;

        static Customer()
        {
             Customers = new ArrayList { "Valeh", "Yaqub", "Mehbare"};
        }

       

        public static string username
        {
            get
            {
                return Username;
            }
            set
            {
                if (CeckIsUserDublicate(value))
                {
                    Console.Write("Bu istifadeci artiq sistemde var");
                }
                else
                {
                    Customers.Add(value);
                    Username = value;
                    Console.WriteLine("Istifadeci sisteme elave edildi");
                }
            }
        }

        public static bool CeckIsUserDublicate(string user)
        {
            bool checkDB = Customers.Contains(user);
            return checkDB;
        }
        public static string password { get; set; }

        

    }
}
