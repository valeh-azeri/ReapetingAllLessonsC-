using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronOcr;
using DynamicTesseract;

namespace İREONTESSERACKT
{
    class Program
    {
        static void Main(string[] args)
        {
            var ocr = new IronTesseract();

            using (var ocrInput = new OcrInput(@"D:\\i.png"))
            {
                //ocrInput.LoadImage("D:\\i.png");
                //ocrInput.LoadPdf("D:\\i.pdf");

                // Optionally Apply Filters if needed:  
                // ocrInput.Deskew();  // use only if image not straight
                // ocrInput.DeNoise(); // use only if image contains digital noise

                var ocrResult = ocr.Read(ocrInput);
                Console.WriteLine(ocrResult.Text);
                Console.ReadLine();
            }
        }
    }
}
