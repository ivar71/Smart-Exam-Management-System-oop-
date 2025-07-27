using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark) : base(header, body, mark)
        {
            Answers = new Answer[2];
            Answers[0] = new Answer(1, "True");
            Answers[1] = new Answer(2, "False");
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"\n[True/False] {Header}: {Body} ({Mark} marks)");
            foreach (var ans in Answers)
                ans.ShowAnswer();

        }
    }
}