using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Subject
    {
        public int SubjectId;
        public string SubjectName;
        public Exam SubjectExam;

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateExam(Exam exam)
        {
            SubjectExam = exam;
        }

        public void ShowSubject()
        {
            Console.WriteLine($"\nSubject: {SubjectName} (ID: {SubjectId})");
            SubjectExam?.ShowExam();
        }
    }
}
