using System;
using System.Text;

namespace SubstringExtensionMain
{
    public static class SubstringExtension
    {
        public static StringBuilder Substring(this StringBuilder original, int index, int length)
        {
            if (index > original.Length)
            {
                throw new ArgumentOutOfRangeException("The index is bigger than the length of the StringBuilder object.");
            }
            else if (index + length > original.Length)
            {
                throw new ArgumentOutOfRangeException("The requested length is too big.");
            }
            else
            {
                StringBuilder result = new StringBuilder();

                for (int i = index; i < index + length; i++)
                {
                    result.Append(original[i]);
                }

                return result;
            }
        }
    }
}
