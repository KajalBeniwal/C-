using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class5
    {
          public void List5()
        {
            int[] searchHistory = { 101, 202, 303, 404, 505 };
            int n = searchHistory.Length;

            Console.WriteLine("Original Search History:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(searchHistory[i] + " ");
            }

            
            for (int i = 0; i < n / 2; i++)
            {
                int temp = searchHistory[i];
                searchHistory[i] = searchHistory[n - i - 1];
                searchHistory[n - i - 1] = temp;
            }

            Console.WriteLine("\n\nReversed Search History:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(searchHistory[i] + " ");
            }
        }
    }

}

