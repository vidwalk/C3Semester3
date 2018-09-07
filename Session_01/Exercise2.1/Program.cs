using System;

namespace Exercise2._1 {

    class Student {
        public void Hi()
        {
            System.Console.WriteLine("Hi, I am a student");
        }
        
    }

    class DNPStudent : Student{
        public new void Hi()
        {
            System.Console.WriteLine("Hi, I am a DNP student");
        }
    }
    class Program {
        static void Main (string[] args) {
           Student student = new DNPStudent();
           student.Hi();
        }
    }
}