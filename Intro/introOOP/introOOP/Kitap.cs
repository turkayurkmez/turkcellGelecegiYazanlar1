using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introOOP
{
    public class Kitap
    {
        //Bir kitabın .................... vardır.
        private string ad;

        public void SetAd(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new NullReferenceException(nameof(value) + " boş olamaz");
            }
            this.ad = value;
        }

        public string GetAd()
        {
            return ad;
        }

        private decimal fiyat;
        public decimal Fiyat
        {
            get { return fiyat; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("fiyat 0'dan küçük olamaz");
                }
            }
        }

        public string Yazar { get; set; }







    }
}
