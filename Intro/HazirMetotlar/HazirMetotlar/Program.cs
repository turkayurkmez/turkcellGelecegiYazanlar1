using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazirMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime = "adana";
            string toLower = kelime.ToLower();
            Console.WriteLine(toLower);
            string toUpper = kelime.ToUpper();
            Console.WriteLine(toUpper);

            for (int i = 0; i < kelime.Length; i++)
            {
                string subString = kelime.Substring(i);
                Console.WriteLine(subString);
            }

            int indexOf = kelime.IndexOf('i', 5);
            Console.WriteLine(indexOf.ToString());
            //0 dediğimde 1
            //2           4
            //5           -1
            int startIndex = 0;
            string sonuc = string.Empty;
            while (kelime.IndexOf('a', startIndex) != -1)
            {
                startIndex = kelime.IndexOf('a', startIndex);
                sonuc += startIndex.ToString() + "-";
                startIndex++;

            }

            /*
             *  1. string.toCharArray()
             *  2. string.Contains()
             *  3. string.StartsWith()
             *  4. string.Split();
             *  
             */

            //hoşunuza giden char metodlarını çözün.
            


            Console.WriteLine(sonuc);

            Console.WriteLine("--------------------------------------------");
            DateTime dateTime = DateTime.Now;

            Console.WriteLine("Ürünün Fiyatını girin:");
            decimal fiyat = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Kaç taksit olacak?");
            int taksitSayisi = Convert.ToInt32(Console.ReadLine());
            decimal tutar = fiyat / taksitSayisi;
            
            for (int i = 1; i <= taksitSayisi; i++)
            {
                DateTime odemeTarihi = DateTime.Now.AddMonths(i);
                switch (odemeTarihi.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        odemeTarihi = odemeTarihi.AddDays(1);
                        break;
                    case DayOfWeek.Saturday:
                        odemeTarihi = odemeTarihi.AddDays(2);
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"{odemeTarihi.ToLongDateString()} tarihinde ödenecek tutar: {tutar} TL");
            }



            Console.ReadLine();

        }
    }
}
