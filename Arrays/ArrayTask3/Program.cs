using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTask3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int[] numbersArray = new int[5];
            Random rand = new Random();
            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = rand.Next(100000);
            }

            int Min=0;
            
            //int Max;
            for (int i = 0; i < numbersArray.Count(); i++)
            {
                Min = numbersArray[i];
                for (int k = i+1; k < numbersArray.Length; k++)
                {
                    if (Min < numbersArray[k])
                    {
                        Min = numbersArray[i];
                    }
                    else
                    {
                        Min = numbersArray[k];
                    }
                
                }
              
            }
            foreach (var item in numbersArray)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
            Console.WriteLine("Massivdəki ən  kiçik rəqəm :" + Min.ToString());
            int accendinNumber;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                accendinNumber = numbersArray[i];
                for (int k = i+1; k < numbersArray.Length; k++)
                {
                    if (accendinNumber > numbersArray[k])
                    {
                        numbersArray[i] = accendinNumber;
                        numbersArray[k] = numbersArray[i];
                    }
                    else
                    {
                        numbersArray[i] = numbersArray[k];
                    }
                }
                
               
            }
            foreach (var item in numbersArray)
            {
                Console.Write(item + ",");
            }
            Console.ReadLine();

        }
    }
}
