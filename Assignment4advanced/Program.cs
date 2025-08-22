namespace Assignment4advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("123-456", "C# Programming", new string[] { "John Doe", "Jane Smith" },
                         new DateTime(2020, 1, 15), 49.99m),
                new Book("789-012", "Advanced C#", new string[] { "Alice Johnson" },
                         new DateTime(2021, 5, 20), 59.99m),
                new Book("345-678", ".NET Framework", new string[] { "Bob Brown", "Charlie Wilson" },
                         new DateTime(2019, 8, 10), 39.99m)
            };

            Console.WriteLine("=== Using User Defined Delegate ===");
            Console.WriteLine("\nTitles:");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);

            Console.WriteLine("\nAuthors:");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);

            Console.WriteLine("\nPrices:");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);

            Console.WriteLine("\n=== Using Built-in Delegate ===");
            Console.WriteLine("\nTitles:");
            LibraryEngine.ProcessBooksBuiltIn(books, BookFunctions.GetTitle);

            Console.WriteLine("\n=== Using Anonymous Method (GetISBN) ===");
            LibraryEngine.ProcessBooksBuiltIn(books, delegate (Book b)
            {
                return $"ISBN: {b.ISBN}";
            });

            Console.WriteLine("\n=== Using Lambda Expression (GetPublicationDate) ===");
            LibraryEngine.ProcessBooksBuiltIn(books, b =>
                $"Publication Date: {b.PublicationDate.ToString("yyyy-MM-dd")}");

            Console.WriteLine("\n=== Additional Lambda Examples ===");
            Console.WriteLine("\nBooks with Price > $45:");
            LibraryEngine.ProcessBooksBuiltIn(books, b =>
                b.Price > 45 ? $"{b.Title}: {b.Price:C}" : $"{b.Title}: Below $45");
        }
    }
    }
