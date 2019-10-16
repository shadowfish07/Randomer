using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 随机器_new
{
    class BaseRandomer
    {
        protected System.Windows.Forms.Timer bindTimer ;
        protected System.Windows.Forms.Control PrintTo; 
        protected   Random rd = new Random();


        public BaseRandomer (int interval =40)
        {
            bindTimer = new System.Windows.Forms.Timer();
            bindTimer.Interval = interval;
            bindTimer.Tick += Tick;
        }

        public BaseRandomer(System.Windows.Forms.Control printTo,int interval = 40)
        {
            bindTimer = new System.Windows.Forms.Timer();
            bindTimer.Interval = interval ;
            bindTimer.Tick += Tick;
            PrintTo = printTo;
        }
        

        protected  virtual void Tick(object sender, EventArgs e)
        {

            PrintTo.Text = rd.Next().ToString ();

        }

        public void Start()
        {
            bindTimer.Start();
        }

        public void Stop()
        {
            bindTimer.Stop();
        }
        
        public void SetPrintTo(System.Windows.Forms.Control printTo )
        {
            PrintTo = printTo;
        }

    }
}
