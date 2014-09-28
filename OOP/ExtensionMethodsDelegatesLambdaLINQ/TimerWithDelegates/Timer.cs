using System;
using System.Threading;

namespace TimerWithDelegates
{
    public class Timer
    {
        private Action executedAction;

        public Action ExecutedAction
        {
            get
            {
                return executedAction;
            }
            private set
            {
                executedAction = value;
            }
        }

        public Timer()
        {
            this.ExecutedAction = executedAction;
        }

        public void Start(int milliseconds, Action<object> executedAction, object actionParameter)
        {
            Thread.Sleep(milliseconds);
            executedAction(actionParameter);
        }
    }
}
