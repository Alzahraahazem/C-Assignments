using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class TrueFalseQuestion: Question
    {

        public TrueFalseQuestion(string b, int m, Answer rightAnswer)
       : base("True False Question", b, m,
           new Answer[]
           {
            new Answer(1, "True"),
            new Answer(2, "False")
           }, rightAnswer)
        {
        }



    }
}
