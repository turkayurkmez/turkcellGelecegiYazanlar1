using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //.NET 1.1:
            int[] durum1 = Filtreleyici.Filtrele(sayilar,ciftMi);

            //.NET 2.0:
            int[] durum2 = Filtreleyici.Filtrele(sayilar, delegate (int s) { return s % 3 == 0; });
            goster2(durum2);
            //.NET 3.5:
            int[] durum3 = Filtreleyici.Filtrele(sayilar, p => p > 5);
            Console.ReadLine();

        }

        private static void goster(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }

        private static void goster2(int[] array)
        {
            array.ToList().ForEach(x => Console.WriteLine(x));
        }

        //Bunu sınıfa taşıdık:
        //static int[] filtrele(int[] array)
        //{
        //    List<int> sonuc = new List<int>();
        //    foreach (int sayi  in array)
        //    {
        //        if (ciftMi(sayi))
        //        {
        //            sonuc.Add(sayi);
        //        }
        //    }

        //    return sonuc.ToArray();
        //}

        static bool ciftMi(int n)
        {
            return n % 2 == 0;
        }

    }
}
