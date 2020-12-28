using System;
using System.Collections.Generic;
using System.Text;

namespace Test_project3
{
    class Hero
    {
        string name;
        int hp;
        int power;
        int wisdom;
        int agility;

        public Hero(string name, int hp, int power, int wisdom, int agility)
        {
            this.name = name;
            this.hp = hp;
            this.power = power;
            this.wisdom = wisdom;
            this.agility = agility;
        }

        public void Damage(Hero h)
        {
            int hit = power * 3 + wisdom * 2 + agility;
            if (hit > h.hp)
            {
                h.hp = 0;
                Console.WriteLine("Персонаж умер " + h.name);
            }
            else
            {
                h.hp -= hit;
                Console.WriteLine("Нанес " + hit);
                Console.WriteLine(h.name + " осталось здоровья " + hp);
            }

        }
    }
}
