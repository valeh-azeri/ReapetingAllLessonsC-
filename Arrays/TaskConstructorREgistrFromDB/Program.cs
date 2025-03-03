using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConstructorREgistrFromDB
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Valeh","Suleymanov","qaqashqaqash1@gmail.com");
            var chekuser=user1.CheckDublicateUser();
            if (chekuser)
            {
                Console.WriteLine("Bu istifadeci artiq qeydiyyatdan kecib");
            }
            else
            {
                user1.Registr();
               
            }

            Console.ReadLine();
        }
    }
}
