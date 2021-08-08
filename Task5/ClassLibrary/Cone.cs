using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Cone
    {
        public int r;
        public int h;
        public double SBase
        {
            get
            {
                return 3.14 * r * r;
            }
        }
        public double SFull
        {
            get
            {
                return 0.5 * r * h + 3.14 * r * r;
            }
        }


        public Cone(int r, int h)
        {
            this.r = r;
            this.h = h;
        }

        public override string ToString()
        {
            return String.Format("S(base) = {0}; S(full) = {1}", SBase, SFull);
        }
    }
}
