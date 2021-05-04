using System;
using System.Collections.Generic;
using System.Text;

namespace _16StopWatch
{
    class StopWatch
    {
        private DateTime start;

       public StopWatch()
        {
            this.start = DateTime.Now;
        }
        public TimeSpan elapsed()
        {
            return DateTime.Now - this.start;
        }

        public void reset()
        {
            this.start = DateTime.Now;
        }
    }
}
