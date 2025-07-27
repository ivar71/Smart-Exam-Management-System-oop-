using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal abstract class Question
    {
        public string Header;
        public string Body;
        public int Mark;
        public Answer[] Answers;
        public Answer RightAnswer;

        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public abstract void ShowQuestion();

        public bool CheckAnswer(int userChoice)
        {
            return Answers[userChoice - 1].AnswerText == RightAnswer.AnswerText;
        }
    }
}
