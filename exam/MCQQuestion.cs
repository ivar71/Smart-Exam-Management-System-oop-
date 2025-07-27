using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class MCQQuestion:Question
    {

        public MCQQuestion(string header, string body, int mark) : base(header, body, mark) { }

        public override void ShowQuestion()
        {
            Console.WriteLine("MCQ");
            Console.WriteLine($" {Header}: {Body} ({Mark} marks)");
            foreach (var ans in Answers)
                ans.ShowAnswer();
        }
    }
}
