using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskStatik
{
    class Program
    {
        static void Main(string[] args)
        {
            var generatedName=NameGenerateMethod.FulNameShow("ValehValehValeh", "Swkeymanov");
            var generatedName1=NameGenerateMethod.FulNameShow("Valeh", "Swkeymanov");
        }
    }
}
