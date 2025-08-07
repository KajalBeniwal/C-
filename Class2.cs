using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class2
    {
        public void List2()
        {
            int[] price = { 1500, 2300, 999, 3200, 1750 };
            int n = price[0];
            ;
        for (int i=1;i<price.Length;i++)
            {
            if (price[i]>n)
            {
            n=price[i];
            }
            }
Console.WriteLine("Maximum element in Array:" + n);
        }

    }
}
