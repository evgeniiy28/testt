using System;
using System.Collections.Generic;
using System.Text;

static void Main(string[] args)
{
    int[,] nums = new int[10, 10];
    Random rnd = new Random();
    int sum = 0;
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            nums[i, j] = rnd.Next(100);
            Console.Write(nums[i, j] + " ");
            if (i == j)
            {
                sum += nums[i, j];
            }
        }

        Console.WriteLine();
    }
    Console.WriteLine(sum);
}
