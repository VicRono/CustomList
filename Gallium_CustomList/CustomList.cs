using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallium_CustomList
{
    public class CustomList<T> : IEnumerable<T>
    {
        private T[] array;
        private int count;
        private int capacity;
        public int Count { get { return count; } }
        public int Capacity { get; set; }
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

        public CustomList()
        {
            count = 0;
            capacity = 10;
            array = new T[capacity];
            Capacity = capacity;
        }

        // indexer property
        public void Add(T item)
        {
            T[] holderArray;

            if (count == capacity)
            {
                capacity = capacity * 2;
            }
            holderArray = array;
            array = new T[capacity];
            int first = 0;
            foreach (T element in holderArray)
            {
                array[first] = holderArray[first];
                first++;
            }
            count++;
            array[count - 1] = item;
        }

        public override string ToString()
        {
            string v = null;
            for (int i = 0; i < count; i++)
            {
                Convert.ToString(array[i]);
                v += array[i];
            }
            return v;
        }

        public IEnumerator<T> GetEnumarator()
        {
            T[] values = new T[100];
            int head = 0;
            for (int i = head; i >= 0; i--)
            {
                yield return values[i];
            }

        }

        public bool Remove(T value)
        {
            T[] holderArray;
            bool isValue = false;
            holderArray = array;
            for (int i = 0; i < count; i++)
            {
                if (holderArray[i].Equals(value))
                {
                    isValue = true;
                }

            }
            if (isValue)
            {
                isValue = false;
                for (int k = 0; k < count; k++)
                {
                    if (value.Equals(holderArray[k]))
                    {
                        isValue = true;
                    }
                    else if (!isValue)
                    {
                        array[k] = holderArray[k];
                    }
                    if (isValue)
                    {
                        array[k] = holderArray[k + 1];
                    }
                }
            }
            count--;
            return isValue;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}