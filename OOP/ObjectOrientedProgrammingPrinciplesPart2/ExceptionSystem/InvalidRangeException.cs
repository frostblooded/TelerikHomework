using System;

namespace ExceptionSystem
{
    public class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException()
        {
        }

        public InvalidRangeException(string msg, Exception innerException, T minRange, T maxRange)
            :base(msg, innerException)
        {
            MinRange = minRange;
            MaxRange = maxRange;
        }

        public T MinRange { get; set; }
        public T MaxRange { get; set; }
    }
}
