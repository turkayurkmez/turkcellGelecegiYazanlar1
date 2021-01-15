using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap istatistik = new Kitap();
            istatistik.SetAd("Çıplak İstatistik");
            istatistik.Fiyat = 16.5M;
            istatistik.Yazar = "Charles Wheelean";
            //istatistik.Fiyat = 50;
            Console.WriteLine(istatistik.GetAd());
            Console.WriteLine(istatistik.Yazar);
            Kitap roman = new Kitap();
            
           // roman.Ad = "Ay'a İniş";

            Personel personel = new Personel();
            personel.Ad = "Türkay";

            Personel per2 = personel;
            per2.Ad = "Hatice";

            Console.WriteLine(personel.Ad);
            Console.ReadLine();


        }
    }
}
