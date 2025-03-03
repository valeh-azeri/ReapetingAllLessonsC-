using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskStatik
{
    public static class NameGenerateMethod
    {
        

        public static string FulNameShow(string Name, string Surname)
        {
            var fulName = Name + "_" + Surname;
            if (fulName.Length>20)
            {
                fulName = Name.Substring(0,1)+"."+Surname;
                return fulName;
            }
            else
            {
                return Name +"."+ Surname;
            }
        } 
    }
}
