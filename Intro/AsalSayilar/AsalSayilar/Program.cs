using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hadi bir sayı girin:");
            int girilenSayi = 0;
            if (int.TryParse(Console.ReadLine(),out girilenSayi))
            {
                //19
                bool asalMi = true;
                for (int bolen = 2; bolen < girilenSayi; bolen++)
                {
                    if (girilenSayi % bolen == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }

                if (asalMi)
                {
                    Console.WriteLine($"{girilenSayi} asaldır");
                }
                else
                {
                    Console.WriteLine($"{girilenSayi} asal değildir");
                }
            }
            else
            {
                Console.WriteLine("değer sayıya çevrilemedi!!!");
            }
            Console.ReadLine();
        }
    }
}
