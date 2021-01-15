using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaOyunu
{
   public class Oyun
    {
        public Oyuncu BirinciOyuncu { get; set; }
        public Oyuncu IkinciOyuncu { get; set; }

        public void IlkOyuncuZarAt()
        {
            BirinciOyuncu.Oyna();
        }

        public void IkinciOyuncuZarAt()
        {
            IkinciOyuncu.Oyna();
        }

        public Oyuncu Karsilastir()
        {
            if (BirinciOyuncu.OyuncununZari.Deger  > IkinciOyuncu.OyuncununZari.Deger)
            {
                return BirinciOyuncu;
            }
            else if (BirinciOyuncu.OyuncununZari.Deger < IkinciOyuncu.OyuncununZari.Deger)
            {
                return IkinciOyuncu;
            }
            else
            {
                return null;
            }
        }

    }
}
