using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
   public class Panel
    {
        public int En { get; set; }
        public int Boy { get; set; }

        public Panel()
        {
            En = 10;
            Boy = 10;
        }
        public Panel(int en, int boy)
        {
            En = en;
            Boy = boy;
        }

        public void BoyutlariGoster()
        {
            Console.WriteLine($" Panel ölçüleri: {En} : {Boy}");
        }
    }
}
