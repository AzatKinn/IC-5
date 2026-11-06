using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-51, 51);
                Console.Write("{0} ", array[i]);

                if (i % 2 == 0 && array[i] > 0 && array[i] % 2 != 0)
                        k++;
            }
            Console.WriteLine();
            Console.WriteLine(k);
            Console.ReadKey();


        }
    }
}
