using System;

namespace fizzbuzz {
    public class StringFizzBuzz {
        int max;
        public StringFizzBuzz (int value) {
            max = value;
        }
        public String SpecialNumbering () {
            string result = "";
            for (int i = 1; i <= max; i++) {
                if(i % 3 == 0 && i % 5 == 0 ) 
                result = result + "FizzBuzz";
                else if (i % 5 == 0)
                result = result + "Buzz";
                else if (i % 3 == 0 )
                result = result + "Fizz";
                else
                result = result + i;
                if(i < max)
                result = result + ", ";
            }
            return result;
        }
    }
}