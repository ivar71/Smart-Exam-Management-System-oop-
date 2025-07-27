namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter subject name: ");
        string subjectName = Console.ReadLine();
        Subject subject = new Subject(1, subjectName);

        Console.Write("Choose exam type (1 - Final, 2 - Practical): ");
        int examType = int.Parse(Console.ReadLine());

        Console.Write("Enter exam duration (minutes): ");
        int duration = int.Parse(Console.ReadLine());

        Console.Write("Enter number of questions: ");
        int numQuestions = int.Parse(Console.ReadLine());

        Exam exam = (examType == 1)? new FinalExam(duration, numQuestions) : new PracticalExam(duration, numQuestions);

        for (int i = 0; i < numQuestions; i++)
        {
            Console.WriteLine($"\nCreating question {i + 1}:"); 
            Console.Write("Type (1 - MCQ, 2 - True/False): ");
            int qType = int.Parse(Console.ReadLine());

            Console.Write("Header: ");
            string header = Console.ReadLine();

            Console.Write("Body: ");
            string body = Console.ReadLine();

            Console.Write("Mark: ");
            int mark = int.Parse(Console.ReadLine());

            if (qType == 1)
            {
                MCQQuestion q = new MCQQuestion(header, body, mark);
                q.Answers = new Answer[3];
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Choice {j + 1}: ");
                    string answerText = Console.ReadLine();
                    q.Answers[j] = new Answer(j + 1, answerText);
                }

                Console.Write("Correct answer number (1-3): ");
                int correct = int.Parse(Console.ReadLine());
                q.RightAnswer = q.Answers[correct - 1];
                exam.Questions[i] = q;
            }
            else
            {
                TrueFalseQuestion q = new TrueFalseQuestion(header, body, mark);
                Console.Write("Correct answer (1 for True, 2 for False): ");
                int correct = int.Parse(Console.ReadLine());
                q.RightAnswer = q.Answers[correct - 1];
                exam.Questions[i] = q;
            }
        }

        subject.CreateExam(exam);

        Console.WriteLine("\n==== Start Exam ====");
        subject.ShowSubject();

        Console.WriteLine("\n==== End ====");
        Console.ReadKey();


        }
    }
}
