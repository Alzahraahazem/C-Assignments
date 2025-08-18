using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int t, int num, Subject subject)
     : base(t, num, subject) { }

        public override void ShowExam()
        {
            var startTime = DateTime.Now;

            foreach (var question in Questions)
            {
                Console.WriteLine(question);
                foreach (var answer in question.AnswerList)
                    Console.WriteLine(answer);

                Console.WriteLine("Please Enter The answer Id");
                int userAnswerId = int.Parse(Console.ReadLine());
            }
                foreach (var q in Questions)
                {
                    Console.WriteLine($"Question: {q.Body}");
                    Console.WriteLine($"Correct Answer: {q.RightAnswer}");
                }

                Console.WriteLine($"Time = {DateTime.Now - startTime}");
            }

        }
    
}
