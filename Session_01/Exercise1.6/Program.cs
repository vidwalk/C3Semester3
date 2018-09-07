using System;
using DNP.Mathlib;

namespace Exercise1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("" + Calculator.Add(1,2));
            int[] a = new int[] {1,2,3};
            int[] b = new int[] {4,5,6};
            int[] c = Calculator.Add(a,b);
            for(int i = 0 ; i < c.Length; i++)
            Console.Write(c[i] + " ");
        }
    }
}
