using System.Collections;

namespace Assignment2advanced
{
    internal class Program
    {
        #region Q1
        public static void ReverseList<T>(List<T> list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                T temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }
        #endregion

        #region Q2
        public static List<T> EvenList<T>(List<T> list)
        {
            List<T> list2= new List<T>();

            foreach (T item in list) {

                int value=Convert.ToInt32(item);

                if (value % 2 == 0)
                {
                    list2?.Add(item);
                }
            }
            return list2;
        }
        #endregion

        #region Q6
        static int[] RemoveDuplicates(int[] arr)
        {
            return arr.Distinct().ToArray();
        }
        #endregion

        #region Q7
        static void RemoveOddNumbers(ArrayList list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                int num = (int)list[i]; 
                if (num % 2 != 0) 
                {
                    list.RemoveAt(i);
                }
            }
        }
        #endregion

        static void Main(string[] args)
        {
            #region Q1
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original list: " + string.Join(", ", numbers));
            ReverseList(numbers);
            Console.WriteLine("Reversed list: " + string.Join(", ", numbers));
            #endregion

            #region Q2
            List<int> number = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = EvenList(number);
            Console.WriteLine("Even list: " + string.Join(", ", evenNumbers));
            #endregion

            #region Q3
            FixedSizeList<string> list = new FixedSizeList<string>(3);

            list.Add("Apple");
            list.Add("Banana");
            list.Add("Cherry");

            Console.WriteLine(list.Get(0));
            Console.WriteLine(list.Get(2));
            #endregion

            #region Q4

        Console.WriteLine("Enter the Array size: ");
        int N= Convert.ToInt32(Console.ReadLine()!);
        Console.WriteLine("Enter the number of Queries: ");
        int Q= Convert.ToInt32(Console.ReadLine()!);

            Console.WriteLine("Enter the Array elements: ");
            string[] arrInput = Console.ReadLine()!.Split();
            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = Convert.ToInt32(arrInput[i]);
            }

            for (int q = 0; q < Q; q++)
            {
                Console.WriteLine("Enter the  Query: ");
                int X = Convert.ToInt32(Console.ReadLine());
                int count = 0;

                for (int i = 0; i < N; i++)
                {
                    if (arr[i] > X)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
            #endregion

            #region Q5
            Console.WriteLine("Enter the Array size: ");
            int N2 = Convert.ToInt32(Console.ReadLine()!);
            Console.WriteLine("Enter the Array elements: ");
            int[] arr2 = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int[] reversed = (int[])arr2.Clone(); 
            Array.Reverse(reversed);             

            if (arr2.SequenceEqual(reversed))
                Console.WriteLine("YES");
            else 
                Console.WriteLine("NO");
            #endregion

            #region Q6
            int[] arr3 = { 1, 3, 2, 3, 1, 4, 2 };
            int[] noDuplicates = RemoveDuplicates(arr3);

            Console.WriteLine("Original: " + string.Join(", ", arr3));
            Console.WriteLine("No Duplicates: " + string.Join(", ", noDuplicates));
            #endregion

            #region Q7
            ArrayList nums = new ArrayList() { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("Original: " + string.Join(", ", nums.ToArray()));

            RemoveOddNumbers(nums);

            Console.WriteLine("After Removing Odds: " + string.Join(", ", nums.ToArray()));
            #endregion
        }
    }
}
