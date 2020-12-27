using System;
using System.Collections.Generic;
using System.Text;

static void Main(string[] args)
{
    int[] mass = new int[10];

    RndMax(mass);
    RndDiapazon(mass);

    //Рандом с установленным максимумом
    static void RndMax(int[] mass)
    {
        //Просто переменная которая позволяет работать с рандомом
        Random rnd = new Random();
        //здесь создается цикл чтобы заполнить массив
        for (int i = 0; i < 10; i++)
        {
            //устанавливается максимум (т.е. 100)
            mass[i] = rnd.Next(100);
            Console.WriteLine(mass[i]);
        }
    }
    //Рандом с определенным диапазоном
    static void RndDiapazon(int[] mass)
    {
        //Просто переменная которая позволяет раотать с рандомом
        Random rnd = new Random();
        //Здесь создается цикл чтобы заполнить массив
        for (int i = 0; i < 10; i++)
        {
            //Вот здесь ставится диапазон от 10 до 100
            mass[i] = rnd.Next(10, 100);
            //Здесь просто выводится массив
            Console.WriteLine(mass[i]);
        }
    }
}

