using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskArrazList1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string choose;
            Hashtable ht = new Hashtable();
            
            do
            {
                Console.Clear();
                Console.WriteLine("Bu bir İngisli-Azərbaycan Dilində Lüğətdir");
                Console.WriteLine("1. Yeni Element Əlavə et");
                Console.WriteLine("2. Bünüt elementləri göstər");
                Console.WriteLine("3. Söz axtar");
                Console.WriteLine("4. Çıxış");
                choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        Console.Write("Əlavə etmək sitəfiyiniz sözü girin:");
                        string En = Console.ReadLine();
                       

                        bool haveWord = ht.ContainsKey(En);
                        if (haveWord)
                        {
                            Console.WriteLine("Bu Söz artıq Lüğətdə Mövcuddur");
                        }
                        else
                        {
                            Console.Write("Tərcüməsini girin:");
                            string Az = Console.ReadLine();
                            ht.Add(En, Az);
                            Console.WriteLine("Bu söz lüğətə əlavə edildi");
                            Console.WriteLine("Yeni söz əlavə etmək istəyirsini? (H/Y)");
                            string yesNo = Console.ReadLine().ToUpper();
                            if (yesNo == "H")
                            {
                                goto case "1";
                            }
                            else break;
                        }
                       
                        System.Threading.Thread.Sleep(2000); break;

                    case "2":
                        foreach (var item in ht.Keys)
                        {
                            Console.WriteLine("Ingiliscə   :" + item + "    Azərbaycanca:   " + ht[item]);
                        }
                        Console.WriteLine("Çıxmaq istəyirsinizsə istənilən bir düyməyə basın");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.Write("Axtarmaq istədiyiniz sözü girin :");
                        string searched=Console.ReadLine();
                        if (ht.ContainsKey(searched))
                        {
                            Console.Write("Tərcüməsi :" +ht[searched]);
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Axtardığınız söz bazada mövcud  deyil");
                            Console.ReadLine();
                        }
                        break;
                        
                     
                }
                

            }
            while 
            (choose != "4");

        }
    }
}
