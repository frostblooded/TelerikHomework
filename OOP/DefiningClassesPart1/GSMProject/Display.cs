using System;

namespace GSMProject
{
    class Display
    {
        private int? size;
        private int? colorsCount;


        public Display()
        {
            size = null;
            colorsCount = null;
        }

        public Display(int? size)
            : this()
        {
            this.size = size;
        }

        public Display(int? size, int? colorsCount)
            : this(size)
        {
            this.colorsCount = colorsCount;
        }

        public int? Size
        {
            get
            {
                return size;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The entered display size can't be negative.");
                }

                size = value;
            }
        }

        public int? ColorsCount
        {
            get
            {
                return colorsCount;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The entered colors count can't be negative.");
                }

                colorsCount = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Display Size: {0} inches, Display Colors Count: {1}", Size, ColorsCount);
        }
    }
}
