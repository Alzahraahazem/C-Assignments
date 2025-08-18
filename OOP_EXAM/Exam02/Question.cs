using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }


        public Question( string h, string b, int m, Answer[] answers, Answer rightAnswer) { 
            Header = h;
            Body = b;
            Mark = m;
            AnswerList = answers;
            RightAnswer = rightAnswer;
        }

        public override string ToString()
        {
            return $"{Header} {Body} {Mark}\n";
        }


    }
}
