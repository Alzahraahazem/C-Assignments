using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4advanced
{
    public class LibraryEngine
    {
        public delegate string BookFunctionDelegate(Book b);

        public static void ProcessBooks(List<Book> blist, BookFunctionDelegate fPtr)
        {
            foreach (Book B in blist)
            {
                Console.WriteLine(fPtr(B));
            }
        }

        public static void ProcessBooksBuiltIn(List<Book> blist, Func<Book, string> fPtr)
        {
            foreach (Book B in blist)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
