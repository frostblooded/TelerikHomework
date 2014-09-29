using System;
using System.Threading;

namespace TimerClass
{
    class TimerClass
    {
        static void Main()
        {
            Timer timer = new Timer(4, 1500);
            timer.TimeElapsed += timer_TimeElapsed;
            timer.Run();
        }

        static void timer_TimeElapsed(object sender, EventArgs e)
        {
            Console.WriteLine("The timer has elapsed");
        }
    }
}
