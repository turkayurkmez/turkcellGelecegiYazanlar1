using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaOyunu
{
   public class Zar
    {
        //her zarın ....... vardır.
        public int Deger { get; set; }

        //her zar ile ...... yapılır // her zar ..... yapar
        public void At()
        {
            Random random = new Random();
            Deger = random.Next(1, 7);
        }
    }
}
