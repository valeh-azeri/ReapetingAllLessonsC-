using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConstroctorMethods1
{
    public class Student
    {
        string name;
        string surname;
        string className;

        public Student(string Name, string Surname, string ClassName)
        {
            if (Name == "Orxan")
            {
                name = "";
            }
            else
            {
                name = Name;
            }
            
            surname = Surname;
            className = ClassName;
        }
    }
}
