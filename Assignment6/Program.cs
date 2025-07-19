namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //types of argument
            //1) passing by name
            //2) passing by order=value
            //3) passing by reference

           // PrintShapes("*_*", 10); //passing by order //called it without class name because its in the same class with main
           // PrintShapes(count: 10, shape: "*_*"); //passing by name


            int a = 5;
            int b = 6;

            Console.WriteLine($" A is {a}");
            Console.WriteLine($" b is {b}");

           // Swap(ref a, ref b);


            Console.WriteLine($" A is {a}");
            Console.WriteLine($" b is {b}");
        }
    }
}
