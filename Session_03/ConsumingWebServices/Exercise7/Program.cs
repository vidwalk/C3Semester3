using System;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;
namespace Exercise7 {
    class Program {
        public static string Food () {
            var html = @"https://www.data.gov/food/";

            HtmlWeb web = new HtmlWeb ();

            var htmlDoc = web.Load (html);

            var node = htmlDoc.DocumentNode.SelectSingleNode ("//body//div/p");

            return node.InnerText;
        }
        static void Main (string[] args) {
            string s = Food ();
            System.Console.WriteLine (s);
        }
    }
}