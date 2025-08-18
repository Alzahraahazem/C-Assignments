using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal abstract class Exam
    {
        public int Time { get; set; }
        public int NumberofQuestions { get; set; }

        public Question[] Questions { get; set; }

        public Subject Subject { get; set; }

   

    public Exam(int t, int num, Subject subject)
        {
            Time = t;
            NumberofQuestions = num;
            Questions = new Question[num];
        }

        public abstract void ShowExam();

    }
}

