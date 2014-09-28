using System;
using System.Collections;
using System.Collections.Generic;

namespace StudentsWithFirstNameSmallerThanLast
{
    public static class IEnumerableExtension
    {
        public static void ForEach<T>(this IEnumerable<T> collection, Action<object> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }
    }
}
