using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateExam()
        {
            Console.WriteLine("Please Enter the type of Exam (1 for Practical | 2 for Final)");
            int examType = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Please Enter the Time For Exam (30 min to 180 min)");
            int time = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Please Enter the Number of questions");
            int numQuestions = int.Parse(Console.ReadLine()!);

            Exam = examType == 1 ? new PracticalExam(time, numQuestions, this) : new FinalExam(time, numQuestions, this);

            for (int i = 0; i < numQuestions; i++)
            {
                if (examType == 2) 
                {
                    Console.WriteLine("Please Enter the Type of Question (1 for MCQ | 2 For True | False)");
                    int questionType = int.Parse(Console.ReadLine());

                    Console.WriteLine(questionType == 1 ? "MCQ Question" : "True False Question");
                    Console.WriteLine("Please Enter Question Body");
                    string body = Console.ReadLine();

                    Console.WriteLine("Please Enter Question Mark");
                    int mark = int.Parse(Console.ReadLine());

                    if (questionType == 1) 
                    {
                        Console.WriteLine("Choices Of Question");
                        Answer[] answers = new Answer[3];
                        for (int j = 0; j < 3; j++)
                        {
                            Console.WriteLine($"Please Enter Choice number {j + 1}");
                            string choice = Console.ReadLine();
                            answers[j] = new Answer(j + 1, choice);
                        }

                        Console.WriteLine("Please Enter the right answer id");
                        int rightAnswerId = int.Parse(Console.ReadLine());
                        Exam.Questions[i] = new MCQQuestion(body, mark, answers, answers[rightAnswerId - 1]);
                    }
                    else 
                    {
                        Console.WriteLine("Please Enter the right answer id (1 for true | 2 for false)");
                        int rightAnswerId = int.Parse(Console.ReadLine());
                        Exam.Questions[i] = new TrueFalseQuestion(body, mark, new Answer(rightAnswerId, rightAnswerId == 1 ? "True" : "False"));
                    }
                }
                else 
                {
                    Console.WriteLine("MCQ Question");
                    Console.WriteLine("Please Enter Question Body");
                    string body = Console.ReadLine();

                    Console.WriteLine("Please Enter Question Mark");
                    int mark = int.Parse(Console.ReadLine());

                    Console.WriteLine("Choices Of Question");
                    Answer[] answers = new Answer[3];
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"Please Enter Choice number {j + 1}");
                        string choice = Console.ReadLine();
                        answers[j] = new Answer(j + 1, choice);
                    }

                    Console.WriteLine("Please Enter the right answer id");
                    int rightAnswerId = int.Parse(Console.ReadLine());
                    Exam.Questions[i] = new MCQQuestion(body, mark, answers, answers[rightAnswerId - 1]);
                }
            }

            Console.WriteLine("Do you want to Start Exam (Y/N)");
            if (Console.ReadLine().ToUpper() == "Y")
                Exam.ShowExam();
        }
    }


}

