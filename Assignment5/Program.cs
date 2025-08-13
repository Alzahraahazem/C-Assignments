namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.Write("Enter size of  matrix: ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write("1");
                    else
                        Console.Write("0");
                }
                Console.WriteLine();
            }
            #endregion

            #region Q2
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 0;

            foreach (int item in arr)
                sum += item;

            Console.WriteLine("Sum of array elements = " + sum);
            #endregion

            #region Q3
            int[] a = { 2, 5, 8 };
            int[] b = { 1, 3, 9 };
            int[] merged = new int[a.Length + b.Length];

            a.CopyTo(merged, 0);
            b.CopyTo(merged, a.Length);

            Array.Sort(merged);
            Console.WriteLine("Merged array in ascending order:");
            foreach (int x in merged)
                Console.Write(x + " ");
            Console.WriteLine();
            #endregion

            #region Q4
            int[] nums = { 1, 2, 2, 3, 1, 4, 2 };
            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }

            foreach (var k in freq)
                Console.WriteLine($"Element {k.Key} occurs {k.Value} times.");
            #endregion

            #region Q5
            int[] data = { 4, 2, 9, 1, 5, 6 };
            int max = data[0], min = data[0];

            foreach (int val in data)
            {
                if (val > max) max = val;
                if (val < min) min = val;
            }

            Console.WriteLine($"Maximum = {max}, Minimum = {min}");
            #endregion

            #region Q6
            int[] numbers = { 3, 9, 2, 5, 7, 9 };
            int max1 = int.MinValue, max2 = int.MinValue;

            foreach (int val in numbers)
            {
                if (val > max1)
                {
                    max2 = max1;
                    max1 = val;
                }
                else if (val > max2 && val != max1)
                    max2 = val;
            }

            Console.WriteLine("Second largest element: " + max2);
            #endregion

            #region Q7
            int[] num = { 1, 2, 2, 3, 1, 4, 2 };

            for (int i = 0; i < nums.Length; i++)
            {
                bool isCounted = false;

               
                for (int k = 0; k < i; k++)
                {
                    if (nums[i] == nums[k])
                    {
                        isCounted = true;
                        break;
                    }
                }

                if (isCounted)
                    continue;

                int count = 1;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                        count++;
                }

                Console.WriteLine("Element " + nums[i] + " occurs " + count + " times.");
            }
            #endregion


            #region Q8
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine()!;
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            Console.WriteLine(string.Join(" ", words));
            #endregion

            #region Q9
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];

            Console.WriteLine("Enter 4 elements for a 2x2 array:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    arr1[i, j] = int.Parse(Console.ReadLine()!);
                    arr2[i, j] = arr1[i, j];
                }
            }

            Console.WriteLine("Copied 2D array:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(arr2[i, j] + " ");
                Console.WriteLine();
            }
            #endregion

            #region Q10
            int[] array = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Array in reverse order:");
            for (int i = array.Length - 1; i >= 0; i--)
                Console.Write(array[i] + " ");
            Console.WriteLine();
            #endregion


        }
    }
}
