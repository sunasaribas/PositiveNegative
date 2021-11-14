using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) kullanıcıdan tam sayı değer istenecek.sayı pozitifse sayı pozitif mesajı, negatifse negatig mesajı 0 ise sayı 0'dır mesajı ekranda gösterilecek...

            double sayi;

            Console.WriteLine("Bir tam sayı değeri giriniz..");

            sayi = Convert.ToDouble(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine($"Girilen sayı {sayi} pozitiftir");
            }
            else if (sayi < 0)
            {

                Console.WriteLine($"Girilen sayı {sayi} negatiftir");
            }
            else

            {
                Console.WriteLine("Sayı sıfırdır.");
            }

            Console.ReadKey();
        }
    }
}
