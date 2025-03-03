using IronOcr; // OCR.NET kitabxanası

using System;
using System.Drawing; // Bitmap üçün

public class OCR_Example
{
    public static object TesseractVersion { get; private set; }

    public static void Main(string[] args)
    {
        // OCR motorunu yaradın
        IronTesseract Ocr = new IronTesseract();
        Ocr.Configuration.TesseractVersion = TesseractVersion.Latest; // Ən son Tesseract versiyasını istifadə edin
        Ocr.Language = "eng"; // Tanımaq istədiyiniz dil

        // PDF faylını açın və ya görüntüyü yükləyin
        // PDF-dən mətn çıxarmaq üçün IronPDF kitabxanasından istifadə edə bilərsiniz
        // Bu nümunədə bir Bitmap görüntüsünü istifadə edəcəyik

        Bitmap image = (Bitmap)Bitmap.FromFile("path/to/your/image.png"); // Şəklinizin yolunu daxil edin

        // OCR əməliyyatını həyata keçirin
        var Result = Ocr.Read(image);

        // Nəticəni ekrana yazdırın
        Console.WriteLine(Result.txt);

        // Nəticəni fayla yazdırın (isteğe bağlı)
        // System.IO.File.WriteAllText("output.txt", Result.Text);
    }
}