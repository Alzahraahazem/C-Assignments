using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1advanced
{
    internal class Range<T> where T : IComparable<T> , INumber<T>
    {
        public static T max { get; set; }
        public static T min { get; set; }

        public Range(T ma, T mi)
        {
            max = ma;
            min = mi;
        }

        public static bool IsInRange(T  value)
        {
            
            return value.CompareTo(max) <= 0 && value.CompareTo(min) >= 0;
        }

        public static T Length()
        {
            T diff = max - min;

            return diff;
        }
    }
}
