using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapisi_If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz");
            int ilkSayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir sayı daha giriniz.");
            int ikinciSayi = Convert.ToInt32(Console.ReadLine());

            if (ilkSayi > ikinciSayi)
            {
                Console.WriteLine($"ilk sayı yani {ilkSayi} büyüktür");
            }
            else if (ilkSayi < ikinciSayi)
            {
                Console.WriteLine($"ikinci girdiğiniz sayı yani {ikinciSayi} büyüktür");
            }
            else
            {
                Console.WriteLine("Her iki sayı da aynıdır");
            }

            Console.ReadLine();

            Console.WriteLine("Kullanıcı adınızı girin:");

            string ad = Console.ReadLine();
            Console.WriteLine("Şifrenizi girin:");
            string sifre = Console.ReadLine();

            if (ad == "turkay" && sifre == "123")
            {
                Console.WriteLine("Merhaba Türkay!");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı ya da şifre hatalı");
            }

            string ay = "";
            if (ay=="Ocak" || ay=="Şubat")
            {

            }
            Console.ReadLine();

            /*
             * BMI: Body Measure Index
             * turkay@turkayurkmez.com
             */


        }
    }
}
