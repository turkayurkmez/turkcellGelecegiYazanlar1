using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Panel panel = new Panel();
            panel.BoyutlariGoster();

            Panel panel2 = new Panel(150, 75);
            panel2.BoyutlariGoster();
            Console.ReadLine();

            panel.Boy = 15;
            panel.BoyutlariGoster();
        }
    }
}
