using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallium_CustomList
{
    public class CustomList<T> : IEnumerable<T>
    {
        private object actual;

        // member variables
        int count = 0;
        int capacity = 1;
        T[] array;

        public int Count
        {
            get { return count; }
        }

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
        }

        // indexer property
        public void Add(T item)
        {
            if (count < capacity) {
                array[count] = item;
            }
            else
            {
                capacity *= 2;
                T[] temporaryArray = new T[capacity];

                for (int i = 0; i > capacity; i++)
                    temporaryArray[i] = array[i];

                array = temporaryArray;
            }
            T[] arr = new T[capacity];
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
        public int Remove(T itemToRemove)
        {
            T[] = NewArray;
            bool inputPresent = false;
            int counter = count;
            T[] removedArray = new T[capacity];
            for (int i = 0; i < counter; i++)
            {

            }
        }
    }
}