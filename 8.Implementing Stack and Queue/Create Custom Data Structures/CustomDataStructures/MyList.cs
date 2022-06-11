
using System;

namespace CustomDataStructures
{
    public class MyList
    {
        private int[] data;
        private const int capacity = 4;
        public int Count { get; private set; }
        public int this[int Indexer]
        {
            get
            {
                if (Indexer >= this.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return data[Indexer];
            }
            set
            {
                if (Indexer >= this.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                data[Indexer] = value;
            }
        }
        public MyList()
        {
            data = new int[capacity];
            Count = 0;
        }


        public void Add(int number)
        {
            if (Count + 1 == data.Length)
            {
                Resize();
            }           
            data[Count] = number;
            Count++;
        }

        public int RemoveAt(int indexToRemoveAt)
        {
            if (ValidateIndex(indexToRemoveAt))
            {
                int removedValue = data[indexToRemoveAt];
                data[indexToRemoveAt] = default(int);             
                ShiftLeft(indexToRemoveAt);
                Count--;
                if (data.Length/2 > this.Count + 1)
                {
                    Shrink();
                }
                return removedValue;

            }
            return 0;          
        }

        public void Insert(int index, int item)
        {
            ValidateIndex(index);
            int valueAtIndex = data[index];
            ShiftRight(index);
            data[index] = item;
            Count++;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (data[i] == element)
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            ValidateIndex(firstIndex);
            ValidateIndex(secondIndex);
            if (ValidateCount(firstIndex,secondIndex))
            {
                int dataAtFirstIndex = data[firstIndex];
                data[firstIndex] = data[secondIndex];
                data[secondIndex] = dataAtFirstIndex;
            }
            
        }
        private void ShiftLeft(int index)
        {
            for (int i = index; i <= Count - index + 1; i++)
            {
                data[i] = data[i + 1];
            }
        }
        private void ShiftRight(int index)
        {
            
            for (int i = this.Count; i > index ; i--)
            {
                data[i] = data[i-1];
            }
        }

        private void Resize()
        {
            int newSize = data.Length * 2;
            int[] newArray = new int[newSize];
            for (int i = 0; i < data.Length; i++)
            {
                newArray[i] = data[i];
            }
            data = newArray;
        }

        private void Shrink()
        {
            int newSize = data.Length / 2;
            int[] newArray = new int[newSize];
            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = data[i];
            }
            data = newArray;
        }

        private bool ValidateIndex (int index)
        {
            if (index >= 0 && index < data.Length - 1)
            {
                return true;
            }

            return false;
        }
        private bool ValidateCount (int firstIndex, int secondIndex)
        {
            if ((firstIndex > 0 && firstIndex <= Count-1) && (secondIndex > 0 && secondIndex <= Count-1))
            {
                return true;
            }
            return false;
        }
    }

}
