using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 随机器_new
{
    class NumRandomer:BaseRandomer
    {

        protected int min;
        protected int max;
        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }

        public NumRandomer (int min,int max,int interval=40):base (interval)
        {
            Max = max;
            Min = min;
        }

        public NumRandomer (int min, int max, System.Windows.Forms.Control printTo, int interval = 40):base (printTo ,interval)
        {
            PrintTo = printTo;
            Max = max;
            Min = min;
        }

        protected override   void Tick(object sender, EventArgs e)
        {

            PrintTo.Text = rd.Next(min, max + 1).ToString();

        }
    }
}
