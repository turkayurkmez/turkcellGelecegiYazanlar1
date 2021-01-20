using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingDelegates
{
    public static class Filtreleyici
    {

        //public delegate bool Kriter(int n);
        public static int[] Filtrele(int[] array, Func<int,bool> kosul)
        {
            List<int> sonuc = new List<int>();
            foreach (int sayi in array)
            {
                if (kosul(sayi))
                {
                    sonuc.Add(sayi);
                }
            }

            return sonuc.ToArray();
        }
    }
}
