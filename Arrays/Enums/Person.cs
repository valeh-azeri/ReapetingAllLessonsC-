using Enums.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public class Person :BaseClass
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public GenderEnum Gender { get; set; }
        public int GenderInteger { get; set; }

    }
}
