using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int avarage = 0;
            Console.Write("Toplam neçə rəqəm yazıb toplamaq  istərdiniz ? ");
            int[] usersHopeArray = new int [Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < usersHopeArray.Length; i++)
            {
                Console.Write((i+1)+".ci Sayı girin :");
                usersHopeArray[i] = Convert.ToInt32(Console.ReadLine());
                sum += usersHopeArray[i];
            }
            avarage = sum / usersHopeArray.Count();
            Console.WriteLine("Massivdəki elementlərin cəmi= " + sum);
            Console.WriteLine("Massivdəki elementlərin ortalamsı= " + avarage);
            Console.ReadLine();
        }
    }
}
