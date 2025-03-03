using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskİnheriWeryImportant
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop Laptop = new Laptop();
            Laptop.Brand = "ASUS";
            Laptop.Model = "TUF FX705GM";
            Laptop.CPU = "i9";
            Laptop.RAM = "16";
            Laptop.GraphicCard = "APD 6 gb";
            Laptop.ByPrice = 3600M;
            Laptop.CellPrice = 4800M;
            Laptop.OferPrice = 4500M;
            Laptop.Barcode = "123456789";

            VirtualDataBase.NewItem(Laptop);


            Laptop Laptop2 = new Laptop();
            Laptop2.Brand = "ASUS";
            Laptop2.Model = "TUF FX705GM";
            Laptop2.CPU = "i9";
            Laptop2.RAM = "16";
            Laptop2.GraphicCard = "APD 6 gb";
            Laptop2.ByPrice = 3600M;
            Laptop2.CellPrice = 4800M;
            Laptop2.OferPrice = 4500M;
            Laptop2.Barcode = "123456789";

            Laptop.Model = "Rog";
            VirtualDataBase.UpdateItem(Laptop);
            VirtualDataBase.Delete(Laptop);

            Laptop Laptop3 = new Laptop();
            Laptop3.Brand = "ASUS";
            Laptop3.Model = "TUF FX705GM";
            Laptop3.CPU = "i9";
            Laptop3.RAM = "16";
            Laptop3.GraphicCard = "APD 6 gb";
            Laptop3.ByPrice = 3600M;
            Laptop3.CellPrice = 4800M;
            Laptop3.OferPrice = 4500M;
            Laptop3.Barcode = "123456789";
        }
    }
}
