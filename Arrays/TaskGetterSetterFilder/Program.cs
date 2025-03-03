using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskGetterSetterFilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Documentation Valeh = new Documentation();
            Valeh.DocumentName = "AA";
            Valeh.DocumentSerial = "12365487";
            var docNum = Valeh.DocumentSerial;
            Console.WriteLine(docNum);
            Console.ReadLine();
        }
    }
}
