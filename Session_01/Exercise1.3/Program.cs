using System;

namespace Exercise1
{
    class Person
    {
        string name;
        public void Introduce()
        {
            Console.WriteLine("Hi, I am " + name);
        }
        static void Main(string[] args)
        {
            var person = new Person()
            {
                name = "Claudiu"
            };
            person.Introduce();
        }
    }
}
