using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1advanced
{
    internal class Arrange<T> where T : IComparable<T>
    {
        static void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void BubbleSort(T[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }
    }
}
        
