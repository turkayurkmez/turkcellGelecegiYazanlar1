using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaOyunu
{
   public class Oyuncu
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public Zar OyuncununZari { get; set; }

        public void Oyna()
        {
            OyuncununZari.At();
        }
        public Oyuncu()
        {

        }
        public Oyuncu(string ad)
        {
            Ad = ad;
        }

    }
}
