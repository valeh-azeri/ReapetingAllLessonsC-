using Enums.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            firstPerson.Id = 1;
            firstPerson.Name = "Valeh";
            firstPerson.Surname = "Suleymanov";
            firstPerson.CreatedDate = DateTime.Now;
            firstPerson.Gender = GenderEnum.Female;
            firstPerson.GenderInteger = (int)firstPerson.Gender;
        }
    }
}
