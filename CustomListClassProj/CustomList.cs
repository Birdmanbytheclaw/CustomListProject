using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProj
{
    public class CustomList<T>
    {
        T[] Stuff;
        public int Count;
        public int Capacity;
        public CustomList()
        {
            Count = 0;
            Capacity = 4;
            Stuff = new T[Capacity];

        }
        public T this[int index]
        {
            get
            {
                return Stuff[index];
            }
            set
            {
                this[index] = value;
            }
        }

        public void Add(T stuff)
        {

        }
        
    }
    
}
