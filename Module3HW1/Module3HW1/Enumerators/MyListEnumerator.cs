using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW1
{
    public class MyListEnumerator<T> : IEnumerator<T>
    {
        public MyListEnumerator(T[] arrOfValues)
        {
            ArrayOfValues = arrOfValues;
        }

        public int Position { get; set; } = -1;

        public T Current
        {
            get
            {
                return ArrayOfValues[Position];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        private T[] ArrayOfValues { get; set; }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (Position < ArrayOfValues.Length - 1)
            {
                Position++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            Position = -1;
        }
    }
}
