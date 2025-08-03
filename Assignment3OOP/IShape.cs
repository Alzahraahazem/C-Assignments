using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment3OOP
{

    internal interface IShape
    {
        public double Area { get;  }

        public void DisplayShapeInfo()
        {
        }

    }
}
