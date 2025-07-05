using System.Drawing;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ََQ1
            Console.WriteLine("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"the number is {x}");
            #endregion

            //#region Q2
            //string y = "12dgh";
            //int b = Convert.ToInt32(y);
            ////System.FormatException: 'The input string '12dgh' was not in a correct format.'
            //Console.WriteLine(y);
            //#endregion

            //#region Q3
            //float x = 2.7, y = 3.4;
            //float z = x + y;
            //Console.WriteLine(z);
            ////Cannot implicitly convert type 'double' to 'float'. 
            ////An explicit conversion exists(are you missing a cast?)
            //#endregion

            //#region Q4
            //string s1 = "hello";
            //string s2 = s1.Substring(0, 2);
            //Console.WriteLine(s2);
            //#endregion

            //#region Q5
            //int x = 3;
            //int y = x;
            //x = 5;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            ////x=5, y=3
            //#endregion

            //#region Q6
            //point p1 = new point();
            //p1.x = 2;
            //point p2 = p1;
            //Console.WriteLine(p1.x + " " + p2.x);
            ////p1.x=2, p2.x=2
            //#endregion

            //#region Q7
            //Console.WriteLine("Enter s1:");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("Enter s1:");
            //string s2 = Console.ReadLine();
            //Console.WriteLine(s1 + " " + s2);
            //#endregion

            //#region choose
            ////Q8 --> b)	A value 1 will be assigned to d.
            ////Q9 --> d)	6 1
            ////Q10 --> d) 7 7
            //#endregion
        }
    }
}
