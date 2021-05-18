using System;
using System.Collections.Generic;
using System.Text;

namespace _16AccessControl
{
    class AccessControl
    {
        private int currentCount = 0;
        private int maxCount;

        public AccessControl(int maxCount)
        {
            this.maxCount = maxCount;
        }

        public int CurrentCount
        {
            get
            {
                return this.currentCount;
            }
            set
            {
                this.currentCount++;
            }
        }

        public bool canEnter()
        {
            return this.currentCount < this.maxCount;
        }

        public bool canEnter(int persons)
        {
            return this.currentCount + persons <= this.maxCount && this.currentCount + persons >= 0;
        }
        public void Increment()
        {
            this.currentCount++;
        }

        public void Increment(int count)
        {
            this.currentCount += count;
        }

        public void Decrement()
        {
            this.currentCount--;
        }

        public void Decrement(int count)
        {
            this.currentCount -= count;
        }
    }
}
