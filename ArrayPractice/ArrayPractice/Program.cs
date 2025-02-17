using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] adlar = new string[5];
            for (int i = 0; i < adlar.Length; i++)
            {
                Console.WriteLine("Adınızı girin");
                
                adlar[i]= Console.ReadLine();
            }

            foreach (var item in adlar)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
