using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            string girilenSifre = string.Empty;
            do
            {
                Console.WriteLine("Şifrenizi girin:");
                girilenSifre = Console.ReadLine();
            } while (girilenSifre != "1234");


         

        }
    }
}
