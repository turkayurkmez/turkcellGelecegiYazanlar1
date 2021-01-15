using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayidanYaziya
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  45
             *  kırk beş
             *  
             */
            string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };




            Console.WriteLine("İki basamaklı bir sayı giriniz");
            int girilenSayi = int.Parse(Console.ReadLine());
            int onlarBasamagindakiDeger = girilenSayi / 10;
            int birlerBasamagindakiDeger = girilenSayi % 10;
            string okunus = onlar[onlarBasamagindakiDeger] + " " + birler[birlerBasamagindakiDeger];
            Console.WriteLine(okunus);
            Console.ReadLine();
            

            //Tüm koleksiyonların index değeri 0'dan başlar!
            List<string> kullanicilar = new List<string>();
            
            


        }
    }
}
