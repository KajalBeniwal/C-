
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] transaction = { 200, -150, 340, 500, -100 };
            int Sum = 0;
            for(int i = 0; i<transaction.Length; i++)
            {
                Sum += transaction[i];
                
            }
            Console.WriteLine("Total Sum of Transaction:"+Sum);

           // Class1 class1 = new Class1();
            //class1.List();
            //Class2 class2 = new Class2();
            //class2.List2();
            Class3 class3 = new Class3();
            class3.List3();
        }
    }
}
