using System;

namespace Exam
{
    class Exam
    {
        public string student;
        public int rus;
        public int matem;
        public int inf;
        private string v;

        public Exam(string v)
        {
            this.v = v;
        }

        public Exam(string student, int rus, int matem, int inf)
        {
            this.student = student;
            this.rus = rus;
            this.matem = matem;
            this.inf = inf;
        }
        static void Main(string [] args)
        {
            Exam student1 = new Exam("Nikita,4,5,5");
            Exam student2 = new Exam("Marat,5,5,5");
            Exam student3 = new Exam("Ruslan,4,4,4");
            Exam[] exams = { student1, student2, student3 };
            Console.WriteLine("Введите число от 4-5");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 5)
            {
                Console.WriteLine("Поступил студент Марат");
            }
            else
            {
                Console.WriteLine("Поступили студенты Никита и Руслан ");
            }

        }
    }
}
