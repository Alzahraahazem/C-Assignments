using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OOP
{
    internal class _3DPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public _3DPoint() { }

        public _3DPoint(int x, int y)
        {
            X = x;
            Y = y;
            Z = 0;
        }
        public _3DPoint(int x, int y, int z) : this(x, y)
        {
            
                Z = z;  
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})"
            ;
        }


        public static bool operator ==(_3DPoint left, _3DPoint right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (left is null || right is null) return false;

            return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
        }

        public static bool operator !=(_3DPoint left, _3DPoint right) => !(left == right);


    }
}
