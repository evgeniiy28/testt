using System;
using System.Threading;
namespace Exam
{
    class Program
    {
        static void mythread1()
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(0, 2);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void mythread2()
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(-99, -9);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void mythread3()
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(0, 10);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            mythread1();
            mythread2();
            mythread3();
            

        }
    }
}
