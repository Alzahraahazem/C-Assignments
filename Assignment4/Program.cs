using System.Diagnostics.Metrics;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("Enter a number: ");
            int.TryParse(Console.ReadLine(), out int x);

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region Q2
            Console.WriteLine("Enter a number: ");
            int.TryParse(Console.ReadLine(), out int x);

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(x * i);
            }
            #endregion

            #region Q3
            Console.WriteLine("Enter a number: ");
            int.TryParse(Console.ReadLine(), out int x);

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            #endregion

            #region Q4
            Console.WriteLine("Enter two number: ");
            int.TryParse(Console.ReadLine(), out int x);
            int.TryParse(Console.ReadLine(), out int y);
            int p = 1;
            for (int i = 1; i <= y; i++)
            {
                p *= x;
            }
            Console.WriteLine(p);
            #endregion

            #region Q5
            Console.WriteLine("Enter Marks of five subjects: ");
            int sum = 0;
            int av = 0;
            int perc = 0;
            for (int i = 1; i <= 5; i++)
            {
                int.TryParse(Console.ReadLine(), out int x);
                sum += x;


            }
            av = sum / 5;
            perc = (sum * 100) / 500;
            Console.WriteLine($"Total marks = {sum}\r\nAverage Marks ={av}\r\nPercentage = {perc}\r\n");
            #endregion

            #region Q6
            Console.WriteLine("Enter month number: ");
            int.TryParse(Console.ReadLine(), out int month);

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30");
                    break;
                case 2:
                    Console.WriteLine("28");
                    break;

            }
            #endregion

            #region Q7
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result;

            switch (op)
            {
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return;
            }

            Console.WriteLine($"Result: {result}");
            #endregion
            #region Q8
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            char[] reversed = input.ToCharArray();
            Array.Reverse(reversed);

            Console.WriteLine($"Reversed string: {new string(reversed)}");
            #endregion

            #region Q9
            Console.Write("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int reversed = 0;

            while (num != 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }

            Console.WriteLine($"Reversed number: {reversed}");
            #endregion

            #region 10
            Console.Write("Input starting number of range: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input ending number of range: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The prime numbers between {0} and {1} are:", start, end);

            for (int num = start; num <= end; num++)
            {
                bool isPrime = true;
                if (num < 2) continue;

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    Console.Write(num + " ");
            }

            Console.WriteLine();
            #endregion

            #region Q11
            Console.Write("Enter x1 y1: ");
            var p1 = Console.ReadLine().Split();
            int x1 = int.Parse(p1[0]);
            int y1 = int.Parse(p1[1]);

            Console.Write("Enter x2 y2: ");
            var p2 = Console.ReadLine().Split();
            int x2 = int.Parse(p2[0]);
            int y2 = int.Parse(p2[1]);

            Console.Write("Enter x3 y3: ");
            var p3 = Console.ReadLine().Split();
            int x3 = int.Parse(p3[0]);
            int y3 = int.Parse(p3[1]);

            // Check slope: (y2 - y1)/(x2 - x1) == (y3 - y1)/(x3 - x1)
            if ((x2 - x1) * (y3 - y1) == (y2 - y1) * (x3 - x1))
                Console.WriteLine("The points lie on the same straight line.");
            else
                Console.WriteLine("The points do NOT lie on the same straight line.");
            #endregion

            #region Q12
            Console.Write("Enter time taken to complete the task (in hours): ");
            double hours = Convert.ToDouble(Console.ReadLine());

            if (hours >= 2 && hours < 3)
                Console.WriteLine("Highly efficient.");
            else if (hours >= 3 && hours < 4)
                Console.WriteLine("Need to improve speed.");
            else if (hours >= 4 && hours <= 5)
                Console.WriteLine("Provide training to improve speed.");
            else if (hours > 5)
                Console.WriteLine("Asked to leave the company.");
            else
                Console.WriteLine("Invalid input or too fast to be realistic.");
            #endregion

        }
    }
}
