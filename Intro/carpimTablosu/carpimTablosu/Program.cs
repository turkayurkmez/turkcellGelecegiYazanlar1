using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpimTablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  1 x 1 = 1
             *  1 x 2 = 2
             *      .
             *      .
             *      .
             *      .
             *      .
             *      .
             *  1 x 9 = 9
             *  2 x 1 = 2
             *   .
             *   .
             *   .
             *   .
             *   
             */
            for (int a = 1; a < 10; a++)
            {
                for (int b = 1; b < 10; b++)
                {
                    int carpim = a * b;
                    Console.WriteLine($"{a} x {b} = {carpim}");
                }
                Console.WriteLine("--------------------------------");
            }
            Console.ReadLine();
        }
    }
}
