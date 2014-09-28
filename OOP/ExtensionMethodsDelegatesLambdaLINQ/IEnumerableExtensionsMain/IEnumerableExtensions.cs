using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableExtensionsMain
{
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            if (collection == null)
            {
                throw new ArgumentNullException("The collection is empty or isn't initialized!");
            }
            else
            {
                T sum = default(T);

                foreach (var item in collection)
                {
                    sum += (dynamic)item;
                }

                return sum;
            }
        }

        public static T Product<T>(this IEnumerable<T> collection)
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            if (collection == null)
            {
                throw new ArgumentNullException("The collection is empty or isn't initialized!");
            }
            else
            {
                T product = (dynamic)1;

                foreach (var item in collection)
                {
                    product *= (dynamic)item;
                }

                return product;
            }
        }

        public static T Min<T>(this IEnumerable<T> collection)
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            if (collection == null)
            {
                throw new ArgumentNullException("The collection is empty or isn't initialized!");
            }
            else
            {
                T min = collection.First();

                foreach (var item in collection)
                {
                    if (min.CompareTo(item) > 0)
                    {
                        min = item;
                    }
                }

                return min;
            }
        }

        public static T Max<T>(this IEnumerable<T> collection)
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            if (collection == null)
            {
                throw new ArgumentNullException("The collection is empty or isn't initialized!");
            }
            else
            {
                T max = default(T);

                foreach (var item in collection)
                {
                    if (max.CompareTo(item) < 0)
                    {
                        max = item;
                    }
                }

                return max;
            }
        }

        public static T Average<T>(this IEnumerable<T> collection)
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            if (collection == null)
            {
                throw new ArgumentNullException("The collection is empty or isn't initialized!");
            }
            else
            {
                T result = default(T);
                int counter = 0;

                foreach (var item in collection)
                {
                    result += (dynamic)item;
                    counter++;
                }

                return result / (dynamic)counter;
            }
        }
    }
}
