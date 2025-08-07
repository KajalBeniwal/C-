using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp2
{
    internal class Class1
    {
        public void List()
        {
            float sum = 0;
            //float avg = 1;
            float[] score = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
            //int n=score
            for (int i= 0; i < score.Length; i++)
            {
                sum += score[i];
              
            }
            float avg = sum / score.Length;
            Console.WriteLine("Average is:" + avg);
        }
    }
}

