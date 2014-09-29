using System;
using System.Threading;

namespace TimerClass
{
    using System.Threading;

    public class Timer
    {
        // The event that will be raised when time elapses
        public event EventHandler TimeElapsed;

        public int TicksCount { get; private set; }

        public int Interval { get; private set; }

        public Timer(int ticksCount, int interval)
        {
            this.TicksCount = ticksCount;
            this.Interval = interval;
        }

        /// <summary>
        /// The method which raises the event.
        /// </summary>
        /// <param name="ticks"></param>
        protected void OnTimeElapsed(int ticks)
        {
            if (TimeElapsed != null)
            {
                EventArgs e = new EventArgs();
                TimeElapsed(this, e);
            }
        }

        public void Run()
        {
            int ticks = this.TicksCount;
            while (ticks > 0)
            {
                Thread.Sleep(this.Interval);
                ticks--;
                OnTimeElapsed(ticks);
            }
        }
    }
}
