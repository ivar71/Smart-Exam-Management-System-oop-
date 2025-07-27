using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Answer
    {
        public int AnswerId;
        public string AnswerText;

        public Answer(int id, string text)
        {
            AnswerId = id;
            AnswerText = text;
        }

        public void ShowAnswer()
        {
            Console.WriteLine($"{AnswerId}: {AnswerText}");
        }
    }
}
