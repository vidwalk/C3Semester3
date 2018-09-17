using System;

namespace Exercise3._7
{
    class Calculator
    {
        public static int Add(params int[] i)
        {   int sum = 0;
            foreach(int s in i)
            {
                sum = sum + s;
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{1,2,3,4,5};
            System.Console.WriteLine(Calculator.Add(array));
            System.Console.WriteLine(Calculator.Add(2,3,4,5));
        }
    }
}
