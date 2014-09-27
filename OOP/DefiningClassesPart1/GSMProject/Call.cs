using System;

namespace GSMProject
{
    class Call
    {
        private DateTime dateAndTime;
        private string dialedPhoneNumber;
        private int durationInSeconds;

        public Call(DateTime dateAndTime, string dialedPhoneNumber, int durationInSeconds)
        {
            this.DateAndTime = dateAndTime;
            this.DialedPhoneNumber = dialedPhoneNumber;
            this.DurationInSeconds = durationInSeconds;
        }

        public DateTime DateAndTime
        {
            get
            {
                return dateAndTime;
            }
            private set
            {
                dateAndTime = value;
            }
        }

        public string DialedPhoneNumber
        {
            get
            {
                return dialedPhoneNumber;
            }
            private set
            {
                dialedPhoneNumber = value;
            }
        }

        public int DurationInSeconds
        {
            get
            {
                return durationInSeconds;
            }
            private set
            {
                durationInSeconds = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Time of occurance: {0}, Dialed Phone Number: {1}, Duration In Seconds: {2}", DateAndTime, DialedPhoneNumber, DurationInSeconds);
        }

    }
}
