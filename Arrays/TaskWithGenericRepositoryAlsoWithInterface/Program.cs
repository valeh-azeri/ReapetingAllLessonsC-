using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskWithGenericRepositoryAlsoWithInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher();
            teacher1.Id = 1;
            teacher1.Name = "Valeh";
            teacher1.Surname = "Suleymanov";
            teacher1.Profation = "Chemistry";

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Tural";
            customer1.Surname="Veliyev";
            customer1.userName = "qaqashqaqash";

            Student student1 = new Student();
            student1.Id = 1;
            student1.Name = "Ehmed";
            student1.Surname = "Eliyev";
            student1.Class = "11B";

            GenericRepository<Teacher> Teacher = new GenericRepository<Teacher>();
            Teacher.Add(teacher1);
            Teacher.Delete(teacher1);
            Teacher.Update(teacher1);
            Teacher.GetAll();


            GenericRepository<Customer> Customer = new GenericRepository<Customer>();
            Customer.Add(customer1);
            Customer.Delete(customer1);
            Customer.Update(customer1);
            Customer.GetAll();

            GenericRepository<Student> Student = new GenericRepository<Student>();
            Student.Add(student1);
            Student.Delete(student1);
            Student.Update(student1);
            Student.GetAll();
        }
    }
}
