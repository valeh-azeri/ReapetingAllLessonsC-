using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConstructorREgistrFromDB
{
    public class User
    {
        

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }


        public User(string name, string surname, string email)
        {
            Name = name;
            Surname = surname;
            Email = email;
        }

        // yoxla  gör  həmin email qeydiyyatdan keçibmi ?
        private bool CheckUserFormDB()
        {
            string[] registeredEmail = new string[]
           {
                "sadiqkor@hotmail.com",
                "qaqashqaqash@gmail.com",
                "valehsuleyman@gmail.com",
                "sadiqkor@box.az",
           };

            return registeredEmail.Contains(Email);
            
        }

        public bool CheckDublicateUser()
        {
            var result = CheckUserFormDB();
            
            return result;
        }

        public void Registr()
        {
            Console.WriteLine("Qeydiyyatdan  keçdiniz");
           
        }

                             


    }
}
