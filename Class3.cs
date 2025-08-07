using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class3
    {
        public void List3()
        {
            int[] pc = { 102, 215, 324, 453, 536 };
            int n = pc.Length;
            int Sum = 0;
            int Sum2 = 0;
            for(int i = 0; i < n; i++)
            {
                if (pc[i] % 2 == 0)
                {
                    Sum++;

                } else
                {
                    Sum2++; 
                }
                Console.WriteLine("No of Male Participants:" + Sum);
                Console.WriteLine("No of Female Participants:" + Sum2);

            }
        }
    }
}
