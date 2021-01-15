using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //metot - functions
            //işlev ya da eylem.
            mesajGoster("Deneme");
        
            int toplam = topla(5, 12);
            mesajGoster(toplam.ToString());
           

            if (sayiCiftMi(13))
            {
                mesajGoster("Sayı çifttir");
            }
            else
            {
                mesajGoster("Sayı tektir :)");
            }

            Console.ReadLine();
        }
        /// <summary>
        /// Mesajınızı ekranda gösterir.
        /// </summary>
        /// <param name="mesaj">Göstermek istediğiniz mesaj</param>
        static void mesajGoster(string mesaj)
        {
            Console.WriteLine(mesaj);
        }

        static bool sayiCiftMi(int sayi)
        {
            return sayi % 2 == 0;
        }

        static int topla(int x, int y)
        {
            return x + y;
        }
    }
}
