using System;

namespace Exam
{
    class Program
    {
        static void SummDiagonali()
        {
            Random rnd = new Random();
            int[,] array = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j=0; j<10; j++)
                {
                    array[i, j] = rnd.Next(10, 100);
                    Console.Write($"{array[i,j]}");

                }
                Console.WriteLine();
            }
            int SummDiagonals = 0;
            for (int i = 0; i < 10; i++)
            {
                SummDiagonals = SummDiagonals + array[i, i];

            }
            Console.WriteLine($"{SummDiagonals}");
        }
        
    }
}
