using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, int numQuestions) : base(time, numQuestions) { }
        public override void ShowExam()
        {
            Console.WriteLine($"\n=== Final Exam ({Time} mins) ===");

            int total = 0;
            int score = 0;
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Questions[i].ShowQuestion();
                Console.Write("Your answer (choose number): ");
                int choice = int.Parse(Console.ReadLine());

                total += Questions[i].Mark;
                if (Questions[i].CheckAnswer(choice))
                    score += Questions[i].Mark;
            }

            Console.WriteLine($"\nYour grade is: {score} / {total}");

        }
    }
}
