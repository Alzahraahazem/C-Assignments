using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment2OOP
{
    internal class Duration
    {


        public int Hours;
        public int Minutes;
        public int Seconds;

        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds); 
        }


        public override bool Equals(object obj)
        {
            if (obj is Duration other)
                return this.Hours == other.Hours && this.Minutes == other.Minutes && this.Seconds == other.Seconds;

            return false;
        }



        public Duration() { }

        public Duration(int h, int m, int s) { 
        Hours = h; Minutes = m; Seconds = s;
        }

        public Duration(int h)  {
            Hours = h / 3600;
            Minutes =(h % 3600)/60 ;
            Seconds=h%60;
        }

        public int ToTotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.ToTotalSeconds() + d2.ToTotalSeconds());
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.ToTotalSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(d1.ToTotalSeconds() - d2.ToTotalSeconds());
        }
        public static Duration operator ++(Duration d)
        {
            return new Duration(d.ToTotalSeconds() + 60); 
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(d.ToTotalSeconds() - 60);

        }


        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() > d2.ToTotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() < d2.ToTotalSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() >= d2.ToTotalSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() <= d2.ToTotalSeconds();
        }

        public static bool operator true(Duration d)
        {
            return d.ToTotalSeconds() != 0;
        }

        public static bool operator false(Duration d)
        {
            return d.ToTotalSeconds() == 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            DateTime now = DateTime.Today;
            return new DateTime(
                now.Year,
                now.Month,
                now.Day,
                d.Hours,
                d.Minutes,
                d.Seconds
            );
        }

    }
}
