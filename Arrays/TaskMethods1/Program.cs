using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMethods1
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello sh = new SayHello();
            sh.SayHelloTo();
            Console.ReadLine();
        }
    }
}
