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
        private object expected;
        private object value;
        CustomList<T> list = new CustomList<T>();

        public int Count
        {
            get { return count; }
        }

   
        // indexer property
        public void Add(int T)
       
        {
            object get = null;
            get { return list[T]; }
            object set = null;
            set { list[T] = value; }

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
