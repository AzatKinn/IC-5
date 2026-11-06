using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace IC_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            int s = 0;
            for (int i = 0; i <15; i++)
            {
                array[i] = random.Next(0, 51);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int min = array[0];
            foreach (int a in array)                
            {              
                    if (a < min)
                        min = a;               
            }
            Console.WriteLine();
            int max = array[0];
            foreach (int a in array)
            {
                if(a > max)
                    max = a;
            }
            s = max + min;
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
