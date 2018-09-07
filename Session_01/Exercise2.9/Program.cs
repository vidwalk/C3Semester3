using System;

namespace Exercise2._9
{
    static class Helper
    {
        static public int  Add(int a, int b)
        { int sum = a + b;
          System.Console.WriteLine("Result: " + sum); 
          return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Introduce 2 numbers to Add");
            int a= Int32.Parse(Console.ReadLine());
            int b= Int32.Parse(Console.ReadLine());
            Helper.Add(a,b);
        }
    }
}
