﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProj
{
    public class CustomList<T> : IEnumerable
    {
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
        
        public CustomList()
        {            
            Stuff = new T[Capacity];
            TempCount = 0;
        }
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

        public void Add(T stuff)
        {
            CheckCapacity();
            Countincrease();
            AddToNextindex(input);

        }
        public void CheckCapacity()
        {
            if (TempCount == TempCapacity)
            {
                CapacityEnlarge();
                CreateTempArray();
                CombineTempAndPreviouArrays();
            }
        }
        public void CreateTempArray()
        {
            TempStuff = T[TempCapacity];
            for (int i = 0; i < TempCount; i++)
            {
                TempStuff[i] = Stuff;
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
                InitialArray();
                int NewCapacity = 4;
                TempCapacity = NewCapacity;
            }

        }
        public void StuffAddedToNextIndex(T input)
        {
            Stuff[NextSpot] = input;
            NextSpot += 1;
        }
        public void
        public bool Remove(T stuff)
            {
            bool removed = false;
            T[] Temporary = new T[Capacity];

            int j = 0;
            for (int i = j; i < Count; i++)
            {
                if(Equals(ListOfMine[i], stuff) && (i == j))
            {
                    removed = true;

            }
            else
            {
                    Temporary[j] = ListOfMine[i];
                    j++;
            }

            }
            if (removed)
            {
                Count--;
                ListofMine = Temporary;

            }





            return removed;
          
        }
    }
    
}
