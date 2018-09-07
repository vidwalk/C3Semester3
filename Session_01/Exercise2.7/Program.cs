using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise2._7
{
    class Person
    {
        public string name;
        private int age;
        public string Power;

        public int Age { get => age; set => age = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary nicknames = new Dictionary<string, Person>();
            Person person1 = new Person{ name = "Ron", Age = 24, Power = "Rolling"};
            Person person2 = new Person{ name = "Deku", Age = 23, Power = "One for All"};
            Person person3 = new Person{ name = "Secret", Age = 21, Power = "All for One"};
            Person person4 = new Person{ name = "Bakugo", Age = 20, Power = "TNT Sweat"};
            nicknames.Add("Boi", person2);
            nicknames.Add("Rage", person4);
            nicknames.Add("AllMight", person1);
            nicknames.Add("REE", person3);
            System.Console.WriteLine(nicknames.Count);
            System.Console.WriteLine(((Person) nicknames["Boi"]).Age);
             System.Console.WriteLine(((Person) nicknames["AllMight"]).Age);
        }
    }
}
