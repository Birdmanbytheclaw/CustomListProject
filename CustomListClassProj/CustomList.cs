using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProj
{
    public class CustomList<T> : IEnumerable where T : IComparable
    {
        //member Variables
        T[] Stuff;
        T[] TempStuff;
        T item;
        private int TempCount;
        public int Count
        {
            get {
                return TempCount;
                    }
        }
        private int TempCapacity;
        public int Capacity
        {
            get {
                return TempCapacity;   
            }
        }
        public int FollowingIndex;
        //Constructor
        public CustomList()
        {            
            Stuff = new T[Capacity];
            TempCount = 0;
        }
        public int NextSpot;
        public T this[int index]
        {
            get
            {
                if ((index < 0) || (index > TempCount))
                {
                    throw new ArgumentOutOfRangeException("Cannot Be Done");
                }
                else
                {
                    return Stuff[index];
                }
            }
            set
            {
                
                 Stuff[index] = value;
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < TempCount; i++)
            {
                yield return Stuff[i];
            }
        }
        //general Methods
        public void Add(T stuff)
        {
            CheckCapacity();
            AddToCount();
            StuffAddedToNextIndex(input);

        }
        public void CheckCapacity()
        {
            if (TempCount == TempCapacity)
            {
                CapacityEnlarge();
                CreateTempArray();
                CombineTempAndPreviousArrays();
            }
        }
        public void CreateTempArray()
        {
            TempStuff = T[TempCapacity];
            for (int i = 0; i < TempCount; i++)
            {
                TempStuff[i] = Stuff[i];
            }
        }
        public void CombineTempAndPreviousArrays()
        {
            for (int i = 0; i < TempCount; i++)
            {
                TempStuff[i] = Stuff[i];
            }
            Stuff = TempStuff;
        }
        public void CapacityEnlarge()
        {
            if (TempCapacity == 0)
            {
                InitalArray();
                int NewCapacity = 4;
                TempCapacity = NewCapacity;
            }

        }
        public void StuffAddedToNextIndex(T input)
        {
            Stuff[NextSpot] = input;
            NextSpot += 1;
        }
        public void InitalArray()
        {
            TempCapacity = 1;
            Stuff = new T[TempCapacity];
            Stuff[NextSpot] = Stuff[];
        }
        public void AddToCount()
        {
            TempCount += 1;
        }

        //Remove Method
        public bool Remove(T stuff)
            {
            bool removed = false;
            T[] Temporary = new T[Capacity];

            int j = 0;
            for (int i = j; i < Count; i++)
            {
                if(Equals(TempStuff[i], stuff) && (i == j))
            {
                    removed = true;

            }
            else
            {
                    Temporary[j] = TempStuff[i];
                    j++;
            }

            }
            if (removed)
            {
                TempCount--;
                TempStuff = Temporary;

            }
            return removed;
          
        }
    }
    
}
