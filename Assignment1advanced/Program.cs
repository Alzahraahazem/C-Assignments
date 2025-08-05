using System;

namespace Assignment1advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            int[] numbers = { 6, 2, 9, 3, 5 };
                Arrange<int>.BubbleSort(numbers);

            foreach (int i in numbers)
            {
                Console.WriteLine("Sorted strings: " + i);
            }

            string[] names = { "Zahraa", "Ali", "Nour", "Basma" };
            Arrange<string>.BubbleSort(names);

            foreach (string name in names)
            {
                Console.WriteLine("Sorted strings: " + name);
            }
            #endregion

            #region Q2
            Range<int> r = new Range<int>(100, 10);

            Console.WriteLine(Range<int>.IsInRange(50));   
            Console.WriteLine(Range<int>.IsInRange(150));  
            Console.WriteLine(Range<int>.Length());  


            #endregion
        }
    }
}
    