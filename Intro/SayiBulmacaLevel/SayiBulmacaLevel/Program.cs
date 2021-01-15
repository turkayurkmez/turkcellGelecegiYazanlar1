using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiBulmacaLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Oyun level 1 ile başlar.
             * 2. Önce 1 ile oyuncunun level'ı * 100 arasında bir sayı seç.
             * 3. Kullanıcıdan tahmin iste
             * 4. Seçilen sayı ve tahmin karşılaştır.
             * 5. Bilindiyse level atla.
             * 
             * 
             */
            int level = 1;
            bool oyunBittimi = false;
            int secilenSayi = sayiSec(level);
            while (!oyunBittimi)
            {
               
                Console.WriteLine("tahmin edin:");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                string yonlendirme = karsilastir(secilenSayi, tahmin);
                Console.WriteLine(yonlendirme);
                bool bildiMi = kontrol(yonlendirme);
                if (bildiMi)
                {
                    level++;
                    secilenSayi = sayiSec(level);
                }
                if (level==5)
                {
                    Console.WriteLine("Oyun bitti");
                    oyunBittimi = true;
                }
            }
        }

        private static bool kontrol(string kelime)
        {
            return kelime.ToLower() == "bildiniz";
        }

        private static string karsilastir(int secilenSayi, int tahmin)
        {
            if (secilenSayi < tahmin)
            {
                return "Aşağı";
            }
            else if (secilenSayi > tahmin)
            {
                return "Yukarı";
            }
            else
            {
                return "Bildiniz";
            }
        }

        static int sayiSec(int level)
        {
            Random random = new Random();
            int secilenSayi = random.Next(1, level * 100);
            return secilenSayi;
        }
    }
}
