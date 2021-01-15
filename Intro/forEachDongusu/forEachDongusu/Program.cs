using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forEachDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kelimeler = new List<string>();
            kelimeler.Add("şapka");
            kelimeler.Add("masa");
            kelimeler.AddRange(new string[] { "kalem", "defter" });

            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }

            int[] sayilar = { 3, 0, 19, 71 };
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }


            Console.ReadLine();
        }
    }
}
