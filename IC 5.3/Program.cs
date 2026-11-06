using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-51, 51);
                Console.Write("{0,4} ", array[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < n-5; i++)
            {
                for (int j = i+1; j < n-5; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n - 5; i++)
            {
                Console.Write("{0,4} ", array[i]);
            }

            Console.WriteLine();
            for (int i = 5; i<n; i++)
            {
                for (int j = i + 1; j < n ; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 5; i < n; i++)
            {
                Console.Write("{0,4} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
