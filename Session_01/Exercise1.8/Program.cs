using System;

namespace Exercise1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string a = Console.ReadLine();
            char[] c = new char[a.Length];
            for(int i = 0 ; i < a.Length ; i++)
            {
                c[i] = a[a.Length-1-i];
            }
            for(int i = 0 ; i < c.Length ; i++)
                Console.Write(c[i]);
        }
    }
}
