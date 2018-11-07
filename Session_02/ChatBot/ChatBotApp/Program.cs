using System;
using System.Collections.Generic;
using System.Linq;

namespace ChatBot {
    class Program {
        private string name;
        delegate int del ();
        del readNumber = () => Int32.Parse (Console.ReadLine ()); //delegate to read numbers from console
        private SortedDictionary<string, string> bookList = new SortedDictionary<string, string> ();
        public string Name { get => name; set => name = value; }

        public void Exit () {
            System.Console.WriteLine ("Bye " + Name);
            Environment.Exit (0);
        }

        public void ReadName () {
            System.Console.WriteLine ("What is your name? ");
            Name = System.Console.ReadLine ();
            System.Console.WriteLine ("Oh, hi " + Name);
            System.Console.WriteLine ("What would you like to do?");
        }

        public void ShowOptions () {
            System.Console.WriteLine ("1) Play Rock-Paper-Scissor");
            System.Console.WriteLine ("2) Calculate your budget");
            System.Console.WriteLine ("3) Draw me something");
            System.Console.WriteLine ("4) Manage my books list");
            System.Console.WriteLine ("5) Exit");
        }

        public void RPS () {
            System.Console.WriteLine ("Lets play Rock-Paper-Scissor then");
            System.Console.WriteLine ("1) Rock");
            System.Console.WriteLine ("2) Paper");
            System.Console.WriteLine ("3) Scissor");
            System.Console.WriteLine ("4) Stop");
            Random rnd = new Random ();
            int rng = rnd.Next (1, 4);

            bool ok = true;
            while (ok == true) {
                System.Console.WriteLine ("1, 2, 3...");
                switch (readNumber ()) {
                    case 1:
                        if (rng == 3) {
                            System.Console.WriteLine ("Scissor");
                            System.Console.WriteLine ("You won " + Name);
                        } else if (rng == 2) {
                            System.Console.WriteLine ("Paper");
                            System.Console.WriteLine ("You lost to me");
                        } else {
                            System.Console.WriteLine ("Rock");
                            System.Console.WriteLine ("Draw");
                        }
                        break;
                    case 2:
                        if (rng == 3) {
                            System.Console.WriteLine ("Scissor");
                            System.Console.WriteLine ("You lost to me");
                        } else if (rng == 2) {
                            System.Console.WriteLine ("Paper");
                            System.Console.WriteLine ("Draw");
                        } else {
                            System.Console.WriteLine ("Rock");
                            System.Console.WriteLine ("You won " + Name);
                        }
                        break;
                    case 3:
                        if (rng == 3) {
                            System.Console.WriteLine ("Scissor");
                            System.Console.WriteLine ("Draw");
                        } else if (rng == 2) {
                            System.Console.WriteLine ("Paper");
                            System.Console.WriteLine ("You won " + Name);
                        } else {
                            System.Console.WriteLine ("Rock");
                            System.Console.WriteLine ("You lost to me");
                        }
                        break;
                    case 4:
                        ok = false;
                        System.Console.WriteLine ("Ok, to the next thing then");
                        break;
                    default:
                        ok = false;
                        System.Console.WriteLine ("You put something wrong...");
                        break;
                }
            }
        }

        public void CalculateBudget () {
            System.Console.WriteLine ("What is your budget?");
            int budget = readNumber ();
            System.Console.WriteLine ("This is your budget plan " + Name + ":");
            System.Console.WriteLine ("Necessities(50%): " + (budget * 50 / 100));
            System.Console.WriteLine ("Savings(20%): " + (budget * 20 / 100));
            System.Console.WriteLine ("Personal(30%): " + (budget * 30 / 100));
            System.Console.WriteLine ();
        }

        public void DrawSomething () {
            System.Console.WriteLine ("Lets see what I can do");
            Random rnd = new Random ();
            int rng = rnd.Next (1, 4);
            switch (rng) {
                case 1:
                    System.Console.WriteLine (System.IO.File.ReadAllText (@"C:\Users\Claudiu\Desktop\Programming\C#-semester3\Session_02\ChatBot\ChatBotApp\madHeart.txt"));
                    break;
                case 2:
                    System.Console.WriteLine (System.IO.File.ReadAllText (@"C:\Users\Claudiu\Desktop\Programming\C#-semester3\Session_02\ChatBot\ChatBotApp\viking.txt"));
                    break;
                case 3:
                    System.Console.WriteLine (System.IO.File.ReadAllText (@"C:\Users\Claudiu\Desktop\Programming\C#-semester3\Session_02\ChatBot\ChatBotApp\spook.txt"));
                    break;
                default:
                    break;
            }
        }

        public void manageBooks () {
            System.Console.WriteLine ("Lets organize your books");
            bool ok = true;
            string title;
            string author;
            while (ok == true) {
                System.Console.WriteLine ("1) Add book");
                System.Console.WriteLine ("2) Remove book");
                System.Console.WriteLine ("3) Find book");
                System.Console.WriteLine ("4) Sort and show books");
                System.Console.WriteLine ("5) Done");
                switch (readNumber ()) {
                    case 1:
                        System.Console.WriteLine ("Author:");
                        author = Console.ReadLine ();
                        System.Console.WriteLine ("Title:");
                        title = Console.ReadLine ();
                        try {
                            bookList.Add (title, author);
                        } catch (ArgumentException) {
                            Console.WriteLine ("An element with Key = " + title + " already exists.");
                        }
                        System.Console.WriteLine ("Book added to list");
                        break;
                    case 2:
                        System.Console.WriteLine ("Title:");
                        title = Console.ReadLine ();
                        bookList.Remove (title);
                        break;
                    case 3:
                        System.Console.WriteLine ("Title:");
                        title = Console.ReadLine ();
                        try {
                            Console.WriteLine ("For key = " + title + ", Author = {0}.",
                                bookList[title]);
                        } catch (KeyNotFoundException) {
                            Console.WriteLine ("Key = " + title + " is not found.");
                        }
                        break;
                    case 4:
                        Console.WriteLine ("Sorted by Authors:");
                        foreach (KeyValuePair<string, string> sorted in bookList.OrderBy (key => key.Value)) {
                            Console.WriteLine ("Title: {0}, Author: {1}", sorted.Key, sorted.Value);
                        }
                        break;
                    case 5:
                        ok = false;
                        break;
                    default:
                        ok = false;
                        System.Console.WriteLine ("You put something wrong...");
                        break;
                }
            }
        }
        static void Main (string[] args) {
            Program program = new Program ();
            program.ReadName ();
            while (true) {
                program.ShowOptions ();
                switch (Int32.Parse (System.Console.ReadLine ())) {
                    case 1:
                        program.RPS ();
                        break;
                    case 2:
                        program.CalculateBudget ();
                        break;
                    case 3:
                        program.DrawSomething ();
                        break;
                    case 4:
                        program.manageBooks();
                        break;
                    default:
                        program.Exit ();
                        break;
                }
            }
        }
    }
}