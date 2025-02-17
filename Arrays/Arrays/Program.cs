using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameString = new string[6];
            nameString[0] = "Valeh";
            nameString[1] = "Ehmed";
            nameString[2] = "Vaqif";
            nameString[3] = "Vasif";
            nameString[4] = "Yasif";
            nameString[5] = "Hafis";
            int orderBy = 1;
            for (int i = 0; i < nameString.Length; i++)
            {
                Console.WriteLine(orderBy+" : "+ nameString[i]);
                orderBy++;
            }
            Console.ReadLine();
        }
    }
}
