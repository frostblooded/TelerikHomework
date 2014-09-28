using System;

namespace TimerWithDelegates
{
    class TimerWithDelegates
    {
        static void Main()
        {
            Timer timer = new Timer();
            timer.Start(3000, Console.Write, "String.");
            timer.Start(3000, Console.Write, "Sub");
            timer.Start(3000, Console.WriteLine, "String");
        }
    }
}
