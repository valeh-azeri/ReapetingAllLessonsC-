using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Bir");

            #region Generic Collections
            List<int> listGeneric = new List<int>();
            listGeneric.Add(5);

            List<Student> newStudent = new List<Student>();
            newStudent.Add(new Student
            {
                Id = 1,
                Name = "Valeh",
                Surname="Suleymanov",
                Age=42
            });
            #endregion
            #region Task In Lesson 1 
            List<int> NewNumbers = new List<int>();
            int[] numbers = new int[10];
            numbers[0] = 11;
            numbers[1] = 12;
            numbers[2] = 13;
            numbers[3] = 14;
            numbers[4] = 15;
            numbers[5] = 16;
            numbers[6] = 17;
            numbers[7] = 18;
            numbers[8] = 19;
            numbers[9] = 20;

            foreach (var item in numbers)
            {
                NewNumbers.Add(item);
            }

            foreach (var item in NewNumbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


            NewNumbers.ForEach(x => Console.WriteLine(x));
            Console.ReadLine();
            #endregion
        }
    }
}
