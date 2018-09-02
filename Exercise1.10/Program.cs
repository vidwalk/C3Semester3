using System;
using DNP.Mathlib;

namespace Exercise1._6 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Add: " + Calculator.Add (1, 2));
            int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[] { 4, 5, 6 };
            int[] c = Calculator.Add (a, b);
            for (int i = 0; i < c.Length; i++)
                Console.Write (c[i] + " ");
            Console.WriteLine();
            Console.WriteLine ("Substract: " + Calculator.Substract (2, 1));
            Console.WriteLine ("Division: " + Calculator.Division(2,1));
            Console.WriteLine("Multiplication: " + Calculator.Multiplication(2,3));
        }
    }
}