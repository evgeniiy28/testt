using System;

namespace Exam
{
    class geroy
    {
        public string pers;
        public int hp;
        public int sila;
        public int lovkost;
        public string ydacha;
        public geroy(string pers, int hp, int sila, int lovkost, string ydacha)
        {
            this.pers = pers;
            this.hp = hp;
            this.sila = sila;
            this.lovkost = lovkost;
            this.ydacha = ydacha;
        }


        class draka
        {
            static void Main(string[] args)
            {
                geroy Ivan = new geroy("Иван", 1000, 150, 50, "Малая");
                geroy Vasya = new geroy("Вася", 1500, 200, 70, "Средняя");
                geroy[] geroys = { Ivan, Vasya };
                
                int[] Ivan1 = new int[3];
                int[] Vasya1 = new int[3];
                int a = 1000;
                int b = 150;
                int c = 50;
                int a1 = 1500;
                int b1 = 200;
                int c1 = 70;
                Ivan1[0] = a;
                Ivan1[1] = b;
                Ivan1[2] = c;
                Vasya1[0] = a1;
                Vasya1[1] = b1;
                Vasya1[2] = c1;


                int n;
                int v;
               do
                {
                    Console.WriteLine("Введите номер персонажа, чтобы посмотреть его характеристики( 1 - Иван, 2 - Вася), нажмите 3, чтобы начать бой. 5 - выйти.");
                     n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Иван");
                            Console.WriteLine($"Здоровье - {Ivan1[0]}");
                            Console.WriteLine($"Сила - {Ivan1[1]}");
                            Console.WriteLine($"Ловкость - {Ivan1[2]}");
                            Console.WriteLine("Удача Малая");
                          
                            break;
                        case 2:
                            Console.WriteLine("Вася");
                            Console.WriteLine($"Здоровье - {Vasya1[0]}");
                            Console.WriteLine($"Сила - {Vasya1[1]}");
                            Console.WriteLine($"Ловкость - {Vasya1[2]}");
                            Console.WriteLine("Удача Средняя");
                           
                            break;
                        case 3:
                            
                            do
                            {
                                Console.WriteLine("Введите номер , чтобы поровести симуляцию боя Ивана и Васи( 1 - Бьет Иван, 2 - Бьет Вася), 5 - выйти.");
                                v = Convert.ToInt32(Console.ReadLine());
                                switch (v)
                                {
                                  
                                    case 1:
                                        a1 = a1 - 150;
                                        Console.WriteLine("Иван");
                                        Console.WriteLine($"Здоровье - {a}");
                                        Console.WriteLine($"Сила - {Ivan1[1]}");
                                        Console.WriteLine($"Ловкость - {Ivan1[2]}");
                                        Console.WriteLine("Удача Малая");

                                        Console.WriteLine("Вася");
                                        Console.WriteLine($"Здоровье - {a1}");
                                        Console.WriteLine($"Сила - {Vasya1[1]}");
                                        Console.WriteLine($"Ловкость - {Vasya1[2]}");
                                        Console.WriteLine("Удача Средняя");
                                        if (a1 <= 0)
                                        {
                                            Console.WriteLine("Ivan Win!");
                                        }
                                    

                                        break;
                                    case 2:
                                        a = a - 200;
                                        Console.WriteLine("Иван");
                                        Console.WriteLine($"Здоровье - {a}");
                                        Console.WriteLine($"Сила - {Ivan1[1]}");
                                        Console.WriteLine($"Ловкость - {Ivan1[2]}");
                                        Console.WriteLine("Удача Малая");

                                        Console.WriteLine("Вася");
                                        Console.WriteLine($"Здоровье - {a1}");
                                        Console.WriteLine($"Сила - {Vasya1[1]}");
                                        Console.WriteLine($"Ловкость - {Vasya1[2]}");
                                        Console.WriteLine("Удача Средняя");
                                        if (a <= 0)
                                        {
                                            Console.WriteLine("Vasya Win!");
                                        }
                                       
                                        break;

                                    default:
                                        Console.WriteLine("Такой команды нет");
                                        break;
                                }
                               

                            }
                            while (v < 5);
                            break;

                           
                           
                        default:
                            Console.WriteLine("Такой команды нет");
                            break;

                    }

                    
                } while (n < 5);
            }
           
        }

    }

}
