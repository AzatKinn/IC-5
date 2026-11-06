using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите семь чисел");
            const int n = 7;
            int[] array = new int[n];
            int s = 0;            
            for (int i = 0; i < n; i++)
            {                
                array[i] = Convert.ToInt32(Console.ReadLine());
                s += array[i];
            }
            Console.WriteLine("{0:f2}",((double)s)/n);
            Console.ReadKey();
        }
    }
}
