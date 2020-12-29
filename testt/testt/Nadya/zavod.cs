using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class zavod
    {
        private int  kolmaterial;

        private int predmetprouzv;


        public void proizv(int kol)

        {
            if (kolmaterial <= 0) { Console.WriteLine(" No materials"); }
            else 
            predmetprouzv += kol;
            kolmaterial -= kol;
        }


        public int Predmetprouzv
        {
            get { return weapon; }
            set { weapon = value; }
        }

    }
}
