using System;
using System.Collections.Generic;
using System.Text;

static void Main(string[] args)
{
    int[,] nums = new int[10, 10];
    Random rnd = new Random();
    int max = 0;
    for (int i = 0; i < 10; i++)
    {
        max = 0;
        for (int j = 0; j < 10; j++)
        {
            nums[i, j] = rnd.Next(10, 100);
            Console.Write(nums[i, j] + " ");
            if (max < nums[i, j])
            {
                max = nums[i, j];
            }
        }
        Console.WriteLine("Максимальный: " + max);
    }
}
