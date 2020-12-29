using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
   abstract class abstr
    {
        private int hp = 100;
        private  int protect =100;
        private int weapon;
        public void Atack(int kol)
        {
            if (hp <= 0) { Console.WriteLine("The participant is dead"); }
            else
            {
                if (weapon <= 0) { Console.WriteLine("No weapons or ammo"); }
            } 

            weapon = weapon - kol;

        }
        public int Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

    }



}
