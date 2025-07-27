using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time, int numQuestions) : base(time, numQuestions) { }
        public override void ShowExam()
        {
            Console.WriteLine($"\n=== Practical Exam ({Time} mins) ===");
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Questions[i].ShowQuestion();
                Console.Write("Your answer (choose number): ");
                int choice = int.Parse(Console.ReadLine());

                Console.WriteLine($"Correct Answer: {Questions[i].RightAnswer.AnswerText}\n");
            }
            Console.WriteLine(" zEnd OF Exam.");


        }
    }
}
