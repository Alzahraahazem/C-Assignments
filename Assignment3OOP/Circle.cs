using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3OOP
{
    internal class Circle : ICircle
    {
        public double Reduis {  get; set; }

        public double Area { get { return Reduis * Reduis * 3.14;  } }

        public Circle(double r)
        {
            Reduis = r;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("circle => ");
            Console.WriteLine("reduis => " + Reduis);
            Console.WriteLine("Area => " + Area);

        }

    }
}
