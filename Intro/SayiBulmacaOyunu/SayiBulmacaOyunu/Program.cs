using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiBulmacaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 13, 56, -9, 0, 75 };
            
            
            Random rastgeleSayiUretici = new Random();
            int uretilenSayi = rastgeleSayiUretici.Next(1, 100);
            bool sayiBulunduMu = false;


            while (!sayiBulunduMu)
            {
                Console.WriteLine("Tahmininizi girin:");
                int tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
                if (uretilenSayi > tahminEdilenSayi)
                {
                    Console.WriteLine("Yukarı!");
                }
                else if (uretilenSayi < tahminEdilenSayi)
                {
                    Console.WriteLine("Aşağı!");
                }
                else
                {
                    Console.WriteLine("Eşittir");
                    sayiBulunduMu = true;
                }

            }


            Console.ReadLine();
        }
    }
}
