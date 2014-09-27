using System;
using System.Text;

namespace List
{
    public class GenericList<T>
    {
        private const int initialCount = 16;
        private T[] contents;
        private int writingIndex;
        private int currentCount;

        public GenericList()
        {
            contents = new T[initialCount];
            writingIndex = 0;
            currentCount = initialCount;
        }

        public GenericList(int startingSize)
            : this()
        {
            if (startingSize <= 0)
            {
                throw new ArgumentException("The starting size of the list can't  be zero or a negative number!");
            }
            else
            {
                contents = new T[startingSize];
                currentCount = startingSize;
            }
        }

        public int Count
        {
            get
            {
                return writingIndex;
            }
        }

        public T Min()
        {
            if (Count == 0)
            {
                throw new ArgumentNullException("The list is empty!");
            }
            else if (contents[0] is IComparable<T>)
            {
                T min = contents[0];

                for (int i = 1; i < Count; i++)
                {
                    if ((min as IComparable<T>).CompareTo(contents[i]) > 0)
                    {
                        min = contents[i];
                    }
                }

                return min;
            }
            else
            {
                throw new ArgumentException("The list doesn't containt compareable items.");
            }
        }

        public T Max()
        {
            if (Count == 0)
            {
                throw new ArgumentNullException("The list is empty!");
            }
            else if (contents[0] is IComparable<T>)
            {
                T max = contents[0];

                for (int i = 1; i < Count; i++)
                {
                    if ((max as IComparable<T>).CompareTo(contents[i]) < 0)
                    {
                        max = contents[i];
                    }
                }

                return max;
            }
            else
            {
                throw new ArgumentException("The list doesn't containt compareable items.");
            }
        }

        public void Add(T element)
        {
            if (this.Count > currentCount - 1)
            {
                Expand();
            }

            contents[writingIndex] = element;
            writingIndex++;
        }

        public void Remove(int index)
        {
            if (index >= Count)
            {
                throw new ArgumentOutOfRangeException("The index for Remove() is outside the allowed range.");
            }
            else
            {
                T[] oldArray = (T[])contents.Clone();
                contents = new T[currentCount];

                int pastingIndex = 0;
                for (int copyingIndex = 0; copyingIndex < Count; copyingIndex++, pastingIndex++)
                {
                    if (copyingIndex == index)
                    {
                        copyingIndex++;
                    }

                    contents[pastingIndex] = oldArray[copyingIndex];
                }

                writingIndex--;
            }
        }

        public void Insert(T element, int index)
        {
            if (index >= Count)
            {
                throw new ArgumentException("The index is bigger than the list's count, please use Add() if you want to add something to the end of the list.");
            }
            else
            {
                if (Count >= currentCount - 1)
                {
                    Expand();
                }

                T[] oldArray = (T[])contents.Clone();
                contents = new T[currentCount];

                int pastingIndex = 0;
                for (int copyingIndex = 0; copyingIndex < Count; copyingIndex++, pastingIndex++)
                {
                    if (copyingIndex == index)
                    {
                        contents[pastingIndex] = element;
                        pastingIndex++;
                    }

                    contents[pastingIndex] = oldArray[copyingIndex];
                }

                writingIndex++;
            }
        }

        public void Clear()
        {
            contents = new T[currentCount];
            writingIndex = 0;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (contents[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Count; i++)
            {
                result.AppendLine(String.Format("Cell {0} - {1}", i, contents[i].ToString()));
            }

            return result.ToString();
        }

        private void Expand()
        {
            T[] oldArray = (T[])contents.Clone();
            currentCount *= 2;
            contents = new T[currentCount];

            for (int i = 0; i < Count; i++)
            {
                contents[i] = oldArray[i];
            }
        }

        public T this[int index]
        {
            get
            {
                if (this.Count > index)
                {
                    return contents[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}