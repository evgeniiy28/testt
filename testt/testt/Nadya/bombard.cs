using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class bombard:abstr
    {
        private int moshvsr;

        public int Moshvsr
        {
            get { return moshvsr; }
            set { moshvsr = value; }
        }

        public void vsriv()

        {
            Console.WriteLine( $"There was an explosion with power {moshvsr}" );
        }
    }
}
