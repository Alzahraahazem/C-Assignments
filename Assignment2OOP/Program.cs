using System;
namespace Assignment2OOP
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter coordinates for p1: ");
           bool isparsed = false;
           isparsed = int.TryParse(Console.ReadLine(), out int x);
           int y = int.Parse(Console.ReadLine()!);
           int z = Convert.ToInt32(Console.ReadLine());

            _3DPoint p1 = new _3DPoint(x,y,z);
            Console.WriteLine(p1.ToString());


            Console.WriteLine("Enter coordinates for p2 separated by spaces: ");
            _3DPoint p2= new _3DPoint();
            string[] coordinates = Console.ReadLine()!.Split(' ');

            if (coordinates.Length == 3 &&
                int.TryParse(coordinates[0], out int x1) &&
                int.TryParse(coordinates[1], out int y1) &&
                int.TryParse(coordinates[2], out int z1))
            {
                 p2 = new _3DPoint(x1, y1, z1);
                Console.WriteLine(p2.ToString());
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter 3 integer values separated by spaces.");
            }

            if (p1 == p2)
                Console.WriteLine("they are equal");
            else
                Console.WriteLine("they are not equal");

            _3DPoint[] points = new _3DPoint[3];

            points[0] = new _3DPoint(3, 4, 5);
            points[1]= new _3DPoint(2, 3, 4);   
            points[2]= new _3DPoint(1, 2, 3);


            Console.WriteLine("unSorted Points:");
            foreach (var point in points)
            {
                Console.WriteLine(point);
            } 


            Array.Sort(points, (a, b) =>
            {
                int xCompare = a.X.CompareTo(b.X);
                if (xCompare != 0)
                    return xCompare;
                else
                    return a.Y.CompareTo(b.Y);
            });


            Console.WriteLine("Sorted Points:");
            foreach (var point in points)
            {
                Console.WriteLine(point);
            }


            Console.WriteLine("Add: " + Math.Add(10, 5));
            Console.WriteLine("Subtract: " + Math.Subtract(10, 5));
            Console.WriteLine("Multiply: " + Math.Multiply(10, 5));
            Console.WriteLine("Divide: " + Math.Divide(10, 5));


            Duration D1 = new Duration(1, 10, 15);
            Duration D2 = new Duration(7800);
            Duration D3 = new Duration(666);

            Console.WriteLine("ToString:");
            Console.WriteLine("D1: " + D1);
            Console.WriteLine("D2: " + D2);
            Console.WriteLine("D3: " + D3);

            Console.WriteLine("\nEquals & GetHashCode:");
            Console.WriteLine("D1 equals D2? " + D1.Equals(D2));
            Console.WriteLine("D1 hash: " + D1.GetHashCode());
            Console.WriteLine("D2 hash: " + D2.GetHashCode());

            Console.WriteLine("\nOperator + and -:");
            Duration sum = D1 + D2;
            Console.WriteLine("D1 + D2: " + sum);
            Duration diff = D2 - D1;
            Console.WriteLine("D2 - D1: " + diff);

            Console.WriteLine("\nOperator + with int:");
            Duration plusSeconds = D1 + 30;
            Console.WriteLine("D1 + 30 sec: " + plusSeconds);

            Console.WriteLine("\nPrefix Increment & Decrement:");
            D3 = ++D1;
            Console.WriteLine("++D1: " + D3);
            D3 = --D2;
            Console.WriteLine("--D2: " + D3);

            Console.WriteLine("\nComparison Operators:");
            Console.WriteLine("D1 > D2? " + (D1 > D2));
            Console.WriteLine("D1 < D2? " + (D1 < D2));
            Console.WriteLine("D1 >= D3? " + (D1 >= D3));
            Console.WriteLine("D1 <= D3? " + (D1 <= D3));

            Console.WriteLine("\nTrue / False Operators:");
            if (D1)
                Console.WriteLine("D1 is not zero");
            else
                Console.WriteLine("D1 is zero");

            Duration zeroDuration = new Duration(0, 0, 0);
            if (zeroDuration)
                Console.WriteLine("Zero duration is not zero");
            else
                Console.WriteLine("Zero duration is zero");

            Console.WriteLine("\nExplicit Cast to DateTime:");
            DateTime time = (DateTime)D1;
            Console.WriteLine("D1 as DateTime: " + time.ToLongTimeString());
        }

      
    }
}
