using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *    +,*,-,/,%
             */
            string ad = "Türkay";
            string soyad = "Ürkmez";
            string yas = "40";
           // Console.WriteLine(ad +" "+ soyad + " kişisi "+yas + " yaşındadır");
            Console.WriteLine($"{ad} {soyad} isimli kişi, {yas} yaşındadır");
            int x = 15;
            int y = 5;
            int z = x + y;
            int mod = x % y;
            Console.WriteLine(mod);

            int sayi = 10;
            //sayi = sayi + 1;
            //sayi += 1;
            Console.WriteLine(--sayi);
            Console.WriteLine(sayi--);
            Console.WriteLine(sayi);

            int islem = 10;
            int soru = islem++ + ++islem;
            Console.WriteLine(soru);

            Console.ReadLine();        
        }
    }
}
