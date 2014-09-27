using System;
using System.Collections.Generic;

namespace GSMProject
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;

        public GSM(string model, string manufacturer)
        {
            this.CallHistory = new List<Call>();
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = null;
            this.owner = null;
            this.battery = null;
            this.display = null;
        }

        public GSM(string model, string manufacturer, decimal? price) 
            : this(model, manufacturer)
        {
            this.price = price;
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        static public GSM IPhone4S
        {
            get
            {
                return new GSM("iPhone", "Apple", 1600.50m, "Nikolay Danailov", new Battery("Li-Po"), new Display(4));
            }
        }

        public List<Call> CallHistory { get; set; }

        public string Model
        {
            get
            {
                return model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The entered model name is null or only consists of white spaces.");
                }

                model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The entered manufactuer name is null or only consists of white spaces.");
                }

                manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return price;
            }
            set
            {
                if (price < 0)
                {
                    throw new ArgumentException("The price can't be negative!");
                }

                price = value;
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The entered owner is null or only consists of white spaces.");
                }

                owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return battery;
            }
            private set
            {
                battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return display;
            }
            private set
            {
                display = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Model: {0}. Manufacturer: {1}, Price: {2}, Owner: {3}, Battery Info: {4}, Display Info: {5}", Model, Manufacturer, Price, Owner, Battery, Display);
        }

        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        private int GetCallsLength()
        {
            int result = 0;

            foreach (var call in CallHistory)
            {
                result += call.DurationInSeconds;
            }

            return result;
        }

        private int SecondsToMinutes(int seconds)
        {
            int result = seconds / 60;

            if (seconds % 60 > 0)
            {
                result++;
            }

            return result;
        }

        public double CalculateTotalCallsPrice(double price)
        {
            int callsLength = GetCallsLength();
            int callsLengthMinutes = SecondsToMinutes(callsLength);
            return callsLengthMinutes * price;
        }
    }
}
