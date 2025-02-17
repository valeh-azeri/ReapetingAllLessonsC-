using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sinifinizdə neçə şagird olsun");
            byte stringLength = Convert.ToByte(Console.ReadLine());
            string[] Name=new string [stringLength];
            int[] Age=new int[stringLength];

            for (int i = 0; i < stringLength; i++)
            {
                
                Console.Write(i+".şagirdin adını girin :");
                Name[i] = Console.ReadLine();
                Console.Write(i + ".Yaşını girin :");
                Age[i] = Convert.ToByte(Console.ReadLine());
            }
            Console.Clear();
            
            Console.WriteLine("Sinif mövcudunuz");

            for (int i = 0; i < stringLength; i++)
            {
                Console.WriteLine(i+"."+Name[i]+"->"+Age[i]);
            }

            Console.ReadLine();
        }
    }
}
