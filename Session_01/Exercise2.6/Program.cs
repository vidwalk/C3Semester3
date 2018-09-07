using System;
using System.Collections;

namespace Exercise2._6
{
    class Schedule
    {
        Hashtable hashtable = new Hashtable();
        public string this[DateTime i]
        {
            get { return (string) hashtable[i]; }
            set { hashtable.Add(i, value);}
        }
        Hashtable hashtable2 = new Hashtable();
        public DateTime this[string i]
        {
            get { return (DateTime) hashtable[i]; }
            set { hashtable.Add(i, value);}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Schedule schedule = new Schedule();
            DateTime now = new DateTime();
            Schedule test = new Schedule() { [now] = "Saturday", [DateTime.Today] = "Sunday"};
            System.Console.WriteLine(test[DateTime.Today]);
            System.Console.WriteLine(test[now]);
            Schedule test2 = new Schedule() { ["Jan 1, 2009"] = DateTime.Parse("Jan 1, 2009") , ["Jan 1, 2010"]= DateTime.Parse("Jan 1, 2010") };
            System.Console.WriteLine(test2["Jan 1, 2009"]);
            System.Console.WriteLine(test2["Jan 1, 2010"]);
        }
    }
}
