using System;
using System.Collections.Generic;
using System.Text;

static void Main(string[] args)
{
    int[,] nums1 = new int[10, 10];
    int[,] nums2 = new int[10, 10];
    int[,] sumnums = new int[10, 10];
    Random rnd = new Random();
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            nums1[i, j] = rnd.Next(10, 100);
            Console.Write(nums1[i, j] + " ");
        }
        Console.WriteLine();
    }
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            nums2[i, j] = rnd.Next(10, 100);
            Console.Write(nums2[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Ответ:");
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            sumnums[i, j] = nums1[i, j] + nums2[i, j];
            Console.Write(sumnums[i, j] + " ");
        }
        Console.WriteLine();
    }
}
