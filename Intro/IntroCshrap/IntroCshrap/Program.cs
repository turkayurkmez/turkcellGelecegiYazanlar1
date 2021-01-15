using System;

namespace IntroCshrap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selam İnsanlık :)");
            /*
             * Sayısal : Matematiksel işlem yapacağınız her şey
             * Sözel:  
             * Mantıksal: 
             */

            /*
               Sayılar
               * Tam sayılar
               * Ondalıklı sayılar
             */

            byte cayBardagi = 255;
            sbyte eksiCayBardagi = -127;

            short suBardagi = -32768;
            ushort pozitifSuBardagi = 65535;

            int surahi = 2000000000;
            uint poizitifSurahi = 4000000000;

            long damacana = 0;
            ulong pozitifDamacana = 0;

            //Ondalıklı sayılar:
            double pi = 3.14;

            float pi2 = 3.14f;
            decimal enHassasPi = 3.14596M;


            char karakter = '?';
            string kelime = "Türkay";

            //1 bit : 0,1
            bool olurMu = true;

          

            try
            {
                Console.WriteLine("Bir sayı giriniz");
                int bolunenSayi = Convert.ToInt32(Console.ReadLine());
                //int dogumYili2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Bir sayı daha giriniz");
                int bolenSayi = Convert.ToInt32(Console.ReadLine());
                int bolum = bolunenSayi / bolenSayi;
                Console.WriteLine(bolum);

            }
            catch (FormatException)
            {
                throw new Exception("Hata oldu");
               // Console.WriteLine("Lütfen sadece sayısal değer girin!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Tam sayılar 0'a bölünemez");
            }
            catch (Exception hata)
            {
                Console.WriteLine("Bir hata oluştu:" + hata.Message );
            }

            //int s = 256;
            //byte q = (byte)s;
            Console.ReadLine();





        }
    }
}
