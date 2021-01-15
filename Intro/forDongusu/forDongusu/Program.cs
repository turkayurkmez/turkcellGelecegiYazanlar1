using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] urunler = { "Telefon", "Laptop", "Ayakkabı", "Pijama","Traş Makinesi","Çorap" };

            //keşke bir değişkenim olsa.... 0'dan başlasa
            //urunler array'inin eleman sayısına kadar
            //1'er 1'er artsa :)
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i]);
            }
           
     

            Console.ReadLine();



        }
    }
}
