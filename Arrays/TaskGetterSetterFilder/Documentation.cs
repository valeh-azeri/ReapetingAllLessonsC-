using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskGetterSetterFilder
{
    public class Documentation
    {
        private string _documentName;


        public string DocumentName
        {
            get
            {
                return _documentName;
            }
            set

            {
                if (value.Length == 2)
                {
                    bool checkResult = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool badCharacter = !char.IsLetter(value[i]);
                        if (badCharacter)
                        {
                            checkResult = true;
                            break;
                        }

                    }
                    if (checkResult)
                    {
                        Console.WriteLine("Vesiqenin seriyasi sadece herflerden ibaret olmalidir");
                    }
                    else
                    {
                        _documentName = value;
                    }

                }
                else
                {
                    Console.WriteLine("Serial 2 herfden Cox ola bilmez");
                }

            }
        }
        private string _documentSerial;
        public string DocumentSerial
        {
            get
            {
                var length = _documentSerial.Length;
                var showFirstNLetter = 3;
                var hiddenString = "";
                for (int i = 0; i < length - showFirstNLetter; i++)
                {
                    hiddenString += "*";
                }
                return _documentSerial.Substring(0, showFirstNLetter) + hiddenString;
            }
            set
            {
                if (value.Length == 8)
                {
                    bool checkResult = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool badCharacter = !char.IsNumber(value[i]);
                        if (badCharacter)
                        {
                            checkResult = true;
                            break;
                        }

                    }
                    if (checkResult)
                    {
                        Console.WriteLine("Vesiqenin seriyasi sadece reqemden ibaret olmalidir");
                    }
                    else
                    {
                        _documentSerial = value;
                    }

                }
                else
                {
                    Console.WriteLine("Serial 8 reqemden Cox ola bilmez");
                }
            }

        }
    }
}
