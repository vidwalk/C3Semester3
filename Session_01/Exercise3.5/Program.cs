using System;

namespace Exercise3._5
{
    class Time
    {
        private int hours;
        private int minutes;

        public int Minutes { get => minutes; set => minutes = value; }
        public int Hours { get => hours; set => hours = value; }

        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
            if(Minutes > 60)
            {
                Minutes = Minutes -60;
                Hours++;
            }
            if(Hours > 24)
            {
                Hours = Hours -24;
            }
        }
        public static Time operator +(Time time1, Time time2)
        {
            Time result = new Time(time1.Hours + time2.Hours, time1.Minutes + time2.Minutes);
            return result;
        }

        public static Time operator +(Time time, int i)
        {
            Time result = new Time(time.Hours, time.Minutes + i);
            return result;
        }

        public  override String ToString() => "Hours: " + Hours + ", Minutes: " + Minutes;
    }
    class Program
    {
        static void Main(string[] args)
        {
           Time time1 = new Time(20, 40);
           Time time2 = new Time(5, 45);
           System.Console.WriteLine("This is time1 " +  time1.ToString());
           System.Console.WriteLine((time1 + time2).ToString());
           System.Console.WriteLine((time1 + 45).ToString());
        }
    }
}
