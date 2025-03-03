using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskİnheriWeryImportant
{
    public class Item : Base
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        private string _barcode;

        public string Barcode
        {
            get { return _barcode; }
            set
            {
                bool checkBarcode = VirtualDataBase.IsbarcodeDublicate(value);
                if (!checkBarcode)
                {
                    _barcode = value;
                }
                else
                {
                    Console.WriteLine("Bu barcode daha öncə başqa məhsul üçün istifadə edilmişdir.");                        
                }
            }
        }

        private decimal _byprice;

        public decimal ByPrice
        {
            get { return _byprice; }
            set
            {
                if (value<=0)
                {
                    Console.WriteLine("Alış qiyməti 1 dən kiçik ola bilməz");
                }
                else
                {
                    _byprice = value;
                }
            }
        }

        private decimal _cellprice;

        public decimal CellPrice
        {
            get { return _cellprice; }
            set
            {
                if (value < _byprice)
                {
                    Console.WriteLine("Satış qiyməti alış qiymətindən kiçik  ola bilməz");
                }
                else
                {
                    _byprice = value;
                }
            }
        }


        private decimal __oferprice;

        public decimal OferPrice
        {
            get { return __oferprice; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Kompaniya qiyməti 1 dən kiçik  ola bilməz");
                }
                else
                {
                    __oferprice = value;
                }
            }
        }
    }
}
