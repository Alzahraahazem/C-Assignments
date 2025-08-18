using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class FinalExam : Exam
    {
        public FinalExam(int t, int num, Subject subject)
        : base(t, num, subject) { }

        public override void ShowExam()
        {
            int totalMarks = 0, userMarks = 0;
            var startTime = DateTime.Now;

            foreach (var question in Questions)
            {
                Console.WriteLine(question);
                foreach (var answer in question.AnswerList)
                    Console.WriteLine(answer);

                Console.Write("Please Enter The answer Id");
                if (question is TrueFalseQuestion)
                    Console.Write(" (1 For True | 2 For False)");
                Console.WriteLine();

                int userAnswerId = int.Parse(Console.ReadLine());
                if (userAnswerId == question.RightAnswer.AnswerId)
                    userMarks += question.Mark;

                totalMarks += question.Mark;
            }
                foreach (var q in Questions)
                {
                    Console.WriteLine($"Question: {q.Body}");
                    Console.WriteLine($"Correct Answer => {q.RightAnswer.AnswerText}");
                }

                Console.WriteLine($"Your Grade is {userMarks} from {totalMarks}");
                Console.WriteLine($"Time = {DateTime.Now - startTime}");
            
        
        }
    }
}
