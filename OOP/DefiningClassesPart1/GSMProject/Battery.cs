using System;

namespace GSMProject
{
    class Battery
    {
        private string model;
        private BatteryType? batteryType;
        private int? hoursIdle;
        private int? hoursTalk;

        public Battery(string model)
        {
            this.Model = model;
            this.HoursIdle = null;
            this.HoursTalk = null;
            this.BatteryType = null;
        }

        public Battery(string model, int? hoursIdle, int? hoursTalk)
            : this(model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public Battery(string model, int? hoursIdle, int? hoursTalk, BatteryType? batteryType)
            :this(model, hoursIdle, hoursTalk)
        {
            this.BatteryType = batteryType;
        }

        public string Model
        {
            get
            {
                return model;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The entered battery model name is empty or filled with Spaces.");
                }

                model = value;
            }
        }

        public BatteryType? BatteryType
        {
            get
            {
                return batteryType;
            }
            private set
            {
                batteryType = value;
            }
        }

        public int? HoursIdle
        {
            get
            {
                return hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The entered idle hours can't be negative.");
                }

                hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get
            {
                return hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The entered talk hours can't be negative.");
                }

                hoursTalk = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Battery Model: {0}, Battery Type: {1}, Battery Hours Idle: {2}, Battery Hours Talk: {3}", Model, BatteryType, HoursIdle, HoursTalk);
        }
    }
}
