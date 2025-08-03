using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3OOP
{
    internal class Rectangle : IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area { get {
                return Length * Width;
            }  }


        public Rectangle( double L, double W)
        {
            Length = L;
            Width = W;
        }
        
        public void DisplayShapeInfo()
        {
            Console.WriteLine("Rectangle => ");
            Console.WriteLine("Length => "+ Length);
            Console.WriteLine("Width => " + Width);
            Console.WriteLine("Area => " + Area);

        }

    }
}