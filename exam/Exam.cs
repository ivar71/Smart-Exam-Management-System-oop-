using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal  abstract class Exam
    {
       public int Time;
        public int NumberOfQuestions;
        public Question[] Questions;

        public Exam(int time, int numQuestions)
        {
            Time = time;
            NumberOfQuestions = numQuestions;
            Questions = new Question[NumberOfQuestions];
        }

        public abstract void ShowExam();


    }
}
