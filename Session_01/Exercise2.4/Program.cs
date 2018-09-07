using System;
using System.Collections.Generic;

namespace Exercise2._4 {
    public class Animal : IComparable {
        string type;
        double weight;
        int speed;

        public Animal(string type, double weight, int speed)
        {
            this.type = type;
            this.weight = weight;
            this.speed = speed;
        }

        public double Weight { get => weight; set => weight = value; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Animal otherAnimal = obj as Animal;
            return otherAnimal.Weight.CompareTo(this.weight);
            // method so you can use sort and have the list sorted in descending order
        }

        public string toString () => type + " " + Weight + " " + speed;
    }



    class Program {
        static void Main (string[] args) {
            List<Animal> animals = new List<Animal> ();
            animals.Add(new Animal("Cow", 80, 20));
            animals.Add(new Animal("Cow", 78, 20));
            animals.Add(new Animal("Cow", 82, 20));
            animals.Add(new Animal("Cow", 76, 20));
            animals.Add(new Animal("Cow", 75, 20));
            animals.Add(new Animal("Cow", 60, 20));
            animals.Add(new Animal("Cow", 65, 20));
            animals.Add(new Animal("Cow", 74, 20));
            animals.Add(new Animal("Cow", 79, 20));
            animals.Add(new Animal("Cow", 70, 20));
            animals.Sort();
            foreach(Animal i in animals)
            System.Console.WriteLine(i.toString());
        }
    }
}