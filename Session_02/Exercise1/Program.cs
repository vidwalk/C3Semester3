using System;
using System.IO;
namespace Exercise1 {
    class Program {
        static void Main (string[] args) {
            string path = @"C:\Users\Claudiu\Desktop\Programming\C#-semester3\Session_02\Exercise1";
            if (!File.Exists (path)) {
                using (StreamWriter sw = File.CreateText (path + "\\myFile.txt")) {
                    sw.Write ("This is so sad\n");
                    sw.Write ("Can we bring reading back");
                }
                using (StreamReader sr = File.OpenText (path + "\\myFile.txt")) {
                    string s = "";
                    string textContent = "";
                    int nr = 0;
                    while ((s = sr.ReadLine ()) != null) {
                        nr++;
                        textContent = textContent + s + " ";
                        Console.WriteLine (s);
                        Console.WriteLine ("Line number: " + nr);
                    }
                    Console.WriteLine (textContent);
                    String[] strings = textContent.Split (" ");
                    Console.WriteLine ("Number of words: " + (strings.Length - 1));
                    int max = 0;
                    for (int i = 0; i < strings.Length; i++) {
                        max = (strings[max].Length < strings[i].Length) ? i : max;
                    }
                    Console.WriteLine ("The longest word is: " + strings[max]);
                }

            }
        }
    }
}