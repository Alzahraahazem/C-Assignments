namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("please enter your number:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 3 == 0 && x % 4 == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            #endregion

            #region Q2
            Console.WriteLine("please enter your number:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
            #endregion

            #region Q3
            Console.WriteLine("please enter your numbers:");
            int[] arr = new int[3];
            arr[0] = Convert.ToInt32(Console.ReadLine());
            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum number is: " + max);
            Console.WriteLine("Minimum number is: " + min);
            #endregion

            #region Q4
            Console.WriteLine("please enter your number:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            #endregion

            #region Q5
            Console.Write("Enter a character: ");
            char inputChar = Convert.ToChar(Console.ReadLine());
            char lowerChar = char.ToLower(inputChar);

            if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else if (char.IsLetter(lowerChar))
            {
                Console.WriteLine("Consonant");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an English letter.");
            }
            #endregion
        }
    }
}
