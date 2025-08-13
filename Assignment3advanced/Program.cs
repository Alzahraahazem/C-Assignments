namespace Assignment3advanced
{
    internal class Program
    {
        #region Q1
        static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
        #endregion

        #region Q2
        public static bool IsBalanced(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in str)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0)
                        return false;

                    char top = stack.Pop();

                    if ((ch == ')' && top != '(') ||
                        (ch == '}' && top != '{') ||
                        (ch == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q1

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("Original Queue: " + string.Join(", ", queue));
            ReverseQueue(queue);
            Console.WriteLine("Reversed Queue: " + string.Join(", ", queue));
            #endregion

            #region Q2
            Console.Write("Enter a string of parentheses: ");
            string input = Console.ReadLine()!;

            if (IsBalanced(input))
                Console.WriteLine("Balanced");
            else
                Console.WriteLine("Not Balanced");
            #endregion
        }
    }
}
