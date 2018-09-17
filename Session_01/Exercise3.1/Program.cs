using System;
using System.Collections.Generic;

namespace Exercise3._1 {
    
    class Program {
        static void Main (string[] args) {
            Stack<String> stack1 = new Stack<String>();
            Stack<int> stack2 = new Stack<int>();
            MyPush(stack1, "I ", "woke ", "up ", "as a vermin");
            MyPush(stack2, 1, 2, 3, 4);
            for(int i = 0; i < 4; i++)
            {
                System.Console.WriteLine(stack1.Pop());
            }
            for(int i = 0; i < 4; i++)
            {
                System.Console.WriteLine(stack2.Pop());
            }
        }

        public static void MyPush<T>(Stack<T> stack, params T[] values)
        {
            foreach( T value in values)
            {
                stack.Push(value);
            }
        }
    }
}