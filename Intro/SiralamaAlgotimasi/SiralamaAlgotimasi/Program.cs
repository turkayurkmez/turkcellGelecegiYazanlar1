using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SiralamaAlgotimasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 26, 18, 7, -35, 65, 89 };
                          //{ 7, 18 ,26,-35,65,89}
                          //{ -35,18,26,7,65,89 }
                          //{ -35,7,26,18,65,89 }

            for (int i = 0; i < numbers.Length -1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int gecici = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = gecici;
                    }
                }
            }

            foreach (int number in numbers)
            {
                Console.Write(number+" ");
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
