using System;

namespace Test_project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero1 = new Hero("Герой", 1000, 50, 10, 30);
            Hero hero2 = new Hero("Самозванник", 600, 10, 50, 50);
            hero1.Damage(hero2);

        }
    }
}
