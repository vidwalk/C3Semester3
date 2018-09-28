using System;
using System.Collections.Generic;

namespace Exercise3._3 {
    public static class ExtendedMethods {
        private static Random rng = new Random ();
        public static T RandomResult<T> (this List<T> a) {   
            return a[rng.Next (0, a.Count - 1)];
        }
        public static void Shuffle<T> (this List<T> list) {
            int n = list.Count;
            while (n > 1) {
                n--;
                int k = rng.Next (0, n - 1 );
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
    class Program {
        static void Main (string[] args) {
            List<int> a = new List<int> () { 1, 2, 3, 4, 5 };
            System.Console.WriteLine (a.RandomResult()); //ExtendedMethods.RandomResult (a)
            a.Shuffle(); // ExtendedMethods.Shuffle (a);
            for (int i = 0; i < a.Count; i++) {
                System.Console.Write (a[i] + " ");
            }
        }
    }
}