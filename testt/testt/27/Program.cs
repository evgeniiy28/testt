using System;
using System.Threading;
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
        Thread thread1 = new Thread(mythread1);
        Thread thread2 = new Thread(mythread2);
        Thread thread3 = new Thread(mythread3);

        thread1.Start();
        thread2.Start();
        thread3.Start();

    }

}
