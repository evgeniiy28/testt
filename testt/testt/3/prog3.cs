using System;
using System.Collections.Generic;
using System.Text;

namespace testt._3
{
    class prog3
    {
        static void Main(string[] args)
        {
            fonetika chaikovski = new fonetika("Чайковский", "Классика", "Времена года", 1875);
            fonetika scriptonit = new fonetika("Скриптонит", "хип-хоп", "Уроборос", 2017);
            fonetika mocart = new fonetika("Моцарт", "Классика", "Симфония №40", 1778);
            fonetika[] fonetikas = { chaikovski, scriptonit, mocart };

            //вводишь нужный жанр
            string janr = Console.ReadLine();

            //поиск по жанру
            foreach (var fonetika in fonetikas)
            {
                if(fonetika.janr == janr)
                {
                    Console.WriteLine(fonetika.ispolnitel);
                }
            }

            //вводишь нужный год
            int godVipuska = Convert.ToInt32(Console.ReadLine());

            //поиск по году
            foreach (var fonetika in fonetikas)
            {
                if(godVipuska == fonetika.godVipuska)
                {
                    Console.WriteLine(fonetika.ispolnitel)
                }
            }
        }
    }
}
