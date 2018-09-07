using System;

namespace Exercise1._9 {
    class StringUtility {

        public static string SummarizeText (string a) {
            if (a.Length > 20) {
                string[] b = a.Split (' ');
                return string.Join (b[3], "...");
            }
            return a;
        }
        static void Main (string[] args) {
            string a = Console.ReadLine ();
            string[] b = a.Split (' ');
            Console.WriteLine (b[0] + " " + b[1] + " " + b[2] + " " + SummarizeText (a));
        }
    }
}