using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarMiYokMu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Eskişehir","Istanbul","Ankara","Izmir","Ankara","Diyarbakir","Sinop" };
            Console.WriteLine("Bir şehir giriniz:");
            string girilenSehir = Console.ReadLine();
            bool varMi = false;
            foreach (string sehir in sehirler)
            {
                Console.Write(sehir + " - ");
                if (sehir == girilenSehir )
                {
                    varMi = true;
                    break;
                }               
            }
            Console.WriteLine();

            if (varMi)
            {
                Console.WriteLine($"{girilenSehir} array'de var.");
            }
            else
            {
                Console.WriteLine($"{girilenSehir} array'de yok.");
            }
            Console.ReadKey();




        }
    }
}
