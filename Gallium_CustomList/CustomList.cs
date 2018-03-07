using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallium_CustomList
{
    public class CustomList<T>
    {
        private object actual;

        // member variables
        int count;
        int capacity;
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
            if (count < capacity ) {
                array[count] = item;
            }
            else
            {
                capacity *= 2;
                T[] temporaryArray = new T[capacity];

                                

                // fill that temporary array with the values from 'array'
                // then add the item to add

                array = temporaryArray;
            }
            // T[] arr = new T[5];
        }
            

    
        
        public int ToString(int v)
        {
            throw new NotImplementedException();
        }

        public int Remove()
        {
            throw new NotImplementedException();
        }
    }
}
