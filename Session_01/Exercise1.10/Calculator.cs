using System;
using System.Collections.Generic;

namespace DNP.Mathlib {
    class Calculator {
        public static int Add (int a, int b) {
            return a + b;
        }

        public static int[] Add (int[] a, int[] b) {
            int[] newArray = new int[a.Length];
            for (int i = 0; i < a.Length; i++) {
                newArray[i] = a[i] + b[i];
            }
            return newArray;
        }

        public static int Substract(int a, int b){
            return a-b;
        }

        public static double Division(int a, int b){
            if(a!=0)
            return a/b;
            return 0;
        }

        public static int Multiplication(int a, int b){
            return a*b;
        }
    }
}