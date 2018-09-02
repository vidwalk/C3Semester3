using System;

namespace Exercise1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
           switch(a)
           {
                case 0:
                Console.WriteLine("This is the first number");
                break;
                case 1:
                Console.WriteLine("This is 1");
                break;
                case 2:
                Console.WriteLine("This is 2");
                break;
                case 3:
                Console.WriteLine("This is 3");
                break;
                case 4:
                Console.WriteLine("This is 4");
                break;
                case 5:
                Console.WriteLine("This is 5");
                break;
                case 6:
                Console.WriteLine("This is 6");
                break;
                case 7:
                Console.WriteLine("This is 7");
                break;
                case 8:
                Console.WriteLine("This is 8");
                break;
                case 9:
                Console.WriteLine("This is 9");
                break;
                case 10:
                Console.WriteLine("This is the last number");
                break;
                default:
                Console.WriteLine("Wrong input");
                break;
           }
        }
    }
}
