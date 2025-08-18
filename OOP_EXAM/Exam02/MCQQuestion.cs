using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class MCQQuestion: Question
    {
        public MCQQuestion(string b, int m, Answer[] answers, Answer rightAnswer)
        : base("MCQ Question", b, m, answers, rightAnswer) { }
    }
}
