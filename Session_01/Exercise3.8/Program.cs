using System;

namespace Exercise3._8 {
   public delegate void notifier (String s);
    class Delegates {
        public void SayHello (String s) {
            System.Console.WriteLine ("Hello " + s);
        }
        public void SayGoodbye (String s) {
            System.Console.WriteLine ("Goodbye " + s);
        }
    }
    class Program {
         
        static void Main (string[] args) {
            String name = Console.ReadLine ();
            Delegates delegates = new Delegates();
            notifier notifier1 = delegates.SayHello;
            notifier1(name);
            notifier notifier2 = delegates.SayGoodbye;
            notifier2(name);
        }
    }
}