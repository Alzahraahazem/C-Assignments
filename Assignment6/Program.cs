namespace Assignment6
{
    internal class Program
    {
        #region Q1
        static void ByValue(int number)
        {
            number = number + 10;  // This  changes the local copy
        }

        static void ByReference(ref int number)
        {
            number = number + 10; // This changes the original variable
        }
        #endregion

        #region Q2
        static void RefByValue(int[] numbers)
        {
            numbers[0] = 100; 

            numbers = new int[] { 9, 9, 9 }; //this  NOT affect the original array
        }

        static void RefByReference(ref int[] numbers)
        {
            numbers[0] = 500; // this  affect the original array

            numbers = new int[] { 7, 7, 7 }; // this  affect the original array
        }
        #endregion

        #region Q3
        static void Calculate(int num1, int num2, int num3, int num4, out int sum, out int difference)
        {
            sum = num1 + num2;           
            difference = num3 - num4;    
        }


        #endregion

        #region Q4
        static int Sum(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;    
                number /= 10;          
            }

            return sum;
        }
        #endregion

        #region Q5
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false; 

            }

            return true; 
        }
        #endregion

        #region Q6
        static void MinMaxArray(int[] arr, ref int min, ref int max)
        {
            min = arr[0];
            max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];

                if (arr[i] > max)
                    max = arr[i];
            }
        }
        #endregion

        #region Q7
        static long Factorial(int number)
        {
            long result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
        #endregion


        #region Q8
        static string ChangeChar(string input, int index, char newChar)
        {
            if (index < 0 || index >= input.Length)
            {
                Console.WriteLine("Invalid index.");
                return input;
            }

            char[] chars = input.ToCharArray();
            chars[index] = newChar;

            return new string(chars);
        }
        #endregion

        static void Main(string[] args)
        {
            #region Q1 
            int x = 5;

            // Pass by value =>original x not change
            ByValue(x);
            Console.WriteLine("num is: " + x); // 5

            // Pass by reference using ref =>original x  change
            ByReference(ref x);
            Console.WriteLine("num is: " + x); // 15

            #endregion

            #region Q2 
            int[] arr = { 1, 2, 3 };

            RefByValue(arr);
            foreach (int i in arr)
                Console.WriteLine($"numbers are:{i} "); //  100, 2, 3


            RefByReference(ref arr);
            foreach(int i in arr) 
                 Console.WriteLine($"numbers are: {i} "); //7, 7, 7

            #endregion

            #region Q3 
            int[] arr2 = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            Calculate(arr2[0], arr2[1], arr2[2], arr2[3], out int sum, out int difference);

            Console.WriteLine("Sum of first two numbers = " + sum);
            Console.WriteLine("Subtraction of first two numbers = " + difference);

            #endregion

            #region Q4
            Console.Write("Enter a number: ");
            int inp = Convert.ToInt32(Console.ReadLine());
            int result = Sum(inp);
            Console.WriteLine($"The sum  is: {result}");
            #endregion

            #region Q5
            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());


            if (IsPrime(input))
                Console.WriteLine($"{input} is a prime number.");
            else
                Console.WriteLine($"{input} is not a prime number.");

            #endregion

            #region Q6
            int[] numbers = { 5, 2, 9, 1, 7 };

            int min = 0, max = 0;

            MinMaxArray(numbers, ref min, ref max);

            Console.WriteLine("Minimum value is: " + min);
            Console.WriteLine("Maximum value is: " + max);
            #endregion

            #region Q7

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine()!);

            long fact = Factorial(num);
            Console.WriteLine($"Factorial of {num} is: {fact}");

            #endregion

            #region Q8
            Console.Write("Enter a string: ");
            string original = Console.ReadLine()!;

            Console.Write("Enter index to change: ");
            int index = int.Parse(Console.ReadLine()!);

            Console.Write("Enter new character: ");
            char newChar = Console.ReadLine()![0];

            string modified = ChangeChar(original, index, newChar);

            Console.WriteLine($"Modified string: {modified}");
            #endregion

        }
    }
}
