namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Subject subject = new Subject(1, "Programming");
                subject.CreateExam();
                Console.WriteLine("Thank you");
            
        }
    }
}
