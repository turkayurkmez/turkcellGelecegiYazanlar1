using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Yöntem:
            string[] kelimeler = new string[] { "Kış", "İlkbahar", "Yaz", "Sonbahar","Deneme","Başka","bir","kelime" };
            //2. Yöntem:
            int[] yaslar = new int[25];
            int[] yillar = { 1991, 1978, 2013, 2016 };
            Console.WriteLine(kelimeler[kelimeler.Length-1]);
            Console.WriteLine(yillar[1]);
            Console.ReadLine();

        }
    }
}
