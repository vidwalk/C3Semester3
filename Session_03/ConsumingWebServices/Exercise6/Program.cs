using System;
using System.Threading.Tasks;

namespace Exercise6 {
    class Kid {
        public async Task<int> TaskCounter (int count) {
            int i;
            for (i = 0; i < count;) {
                i = await Task.Run<int> (() => i = i + 1);
                await Task.Delay (250);
                System.Console.WriteLine (i);
            }
            if (i == count)
                return count;
            //throw new ArgumentNullException(); crashes the whole proram
            return 0;
        }
    }
    class Program {
        static void Main (string[] args) {
            Kid kid = new Kid ();
            System.Console.WriteLine ("How many apples do you want counted?");
            int number = Int32.Parse (Console.ReadLine ());
            Task<int> returnedCounting = kid.TaskCounter (number);
            if (returnedCounting.Result == number)
                System.Console.WriteLine ("I counted correctly");
            else
                System.Console.WriteLine ("Ops");
        }
    }
}