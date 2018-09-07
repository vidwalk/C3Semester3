using System;

namespace Exercise1._7
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = Int32.Parse(Console.ReadLine());
           int b = Int32.Parse(Console.ReadLine());
           if(a > b)
           Console.Write(a);
           else
           Console.Write(b);
        }
    }
}
