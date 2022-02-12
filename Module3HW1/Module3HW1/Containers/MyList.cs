using System;
using System.Collections;
using System.Collections.Generic;

namespace Module3HW1
{
    public class MyList<T> : IMyList<T>
    {
        public MyList()
        {
            ArrayOfValues = new T[0];
            Capacity = 0;
        }

        public MyList(int capacity)
        {
            ArrayOfValues = new T[capacity];
            Capacity = capacity;
        }

        public int Capacity { get; private set; }

        public int Count { get; private set; }

        private T[] ArrayOfValues { get; set; }

        public T this[int index]
        {
            get
            {
                return ArrayOfValues[index];
            }
            set
            {
                ArrayOfValues[index] = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new MyListEnumerator<T>(ArrayOfValues);
        }

        public void Add(T value)
        {
            if (Capacity == Count)
            {
                ChangeArraySize();
            }

            Count++;

            ArrayOfValues[Count - 1] = value;
        }

        public void AddRange(params T[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (Capacity == Count)
                {
                    ChangeArraySize();
                }

                Count++;

                ArrayOfValues[Count - 1] = values[i];
            }
        }

        public bool Remove(T value)
        {
            T[] tempRefToArray;

            for (int i = 0; i < Count; i++)
            {
                if (ArrayOfValues[i].Equals(value))
                {
                    tempRefToArray = new T[Capacity];

                    int k = 0;
                    for (int j = 0; j < Count; j++)
                    {
                        if (j == i)
                        {
                            continue;
                        }

                        tempRefToArray[k++] = ArrayOfValues[j];
                    }

                    ArrayOfValues = tempRefToArray;
                    Count--;

                    return true;
                }
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            if (index > Count - 1 || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (Count > 0)
            {
                T[] tempRefToArray;

                tempRefToArray = new T[Capacity];

                int j = 0;
                for (int i = 0; i < Count; i++)
                {
                    if (i == index)
                    {
                        continue;
                    }

                    tempRefToArray[j++] = ArrayOfValues[i];
                }

                ArrayOfValues = tempRefToArray;
                Count--;
            }
        }

        public void Sort(IComparer<T> comparer)
        {
            for (int i = 0; i < Count; i++)
            {
                for (int j = i + 1; j < Count; j++)
                {
                    if (comparer.Compare(ArrayOfValues[i], ArrayOfValues[j]) > 0)
                    {
                        T temp = ArrayOfValues[i];
                        ArrayOfValues[i] = ArrayOfValues[j];
                        ArrayOfValues[j] = temp;
                    }
                }
            }
        }

        private void ChangeArraySize()
        {
            T[] tempRefToArray;

            if (Capacity == 0)
            {
                Capacity = 4;
                ArrayOfValues = new T[Capacity];

                return;
            }

            Capacity *= 2;
            tempRefToArray = new T[Capacity];

            for (int i = 0; i < Count; i++)
            {
                tempRefToArray[i] = ArrayOfValues[i];
            }

            ArrayOfValues = tempRefToArray;
        }
    }
}
