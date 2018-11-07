using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace Exercise5 {
    class Program {
        static void Main (string[] args) {
            HttpClient client = new HttpClient ();
            Stopwatch stop = new Stopwatch ();
            stop.Start ();
            Task<string> getStringTask = client.GetStringAsync ("https://www.via.dk/");
            string s = getStringTask.Result;
            stop.Stop ();
            System.Console.WriteLine (stop.Elapsed);
        }
    }
}