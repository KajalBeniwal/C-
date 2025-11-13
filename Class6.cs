using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class6
    {
       public void List6()
        { 

            int[] measurements = { 2, 4, 6, 8 };
            int factor = 3;

            Console.WriteLine("Original Measurements:");
            for (int i = 0; i < measurements.Length; i++)
            {
                Console.Write(measurements[i] + " ");
            }

            
            for (int i = 0; i < measurements.Length; i++)
            {
                measurements[i] = measurements[i] * factor;
            }

            Console.WriteLine("\n\nAdjusted Measurements (after multiplying by " + factor + "):");
            for (int i = 0; i < measurements.Length; i++)
            {
                Console.Write(measurements[i] + " ");
            }
        }
    }

}

