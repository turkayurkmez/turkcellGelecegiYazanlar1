using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            int sonuc = x.KaresiniAl();
            Console.WriteLine(sonuc);
         

            string ornek = "Turkcell Geleceği Yazanlar";
            Console.WriteLine(ornek.BosluklariKaldir());
            Console.ReadLine();


        }
    }
}
