using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures
{
    internal class MyStack
    {
        private int[] data;
        private const int startCapacity = 4;
        public int Count {get; private set;}

        public MyStack()
        {
            data = new int[startCapacity];
            Count = 0;
        }

        public void Push(int element)
        {
            if (Count + 1 == data.Length)
            {
                Resize();
            }
            data[Count] = element;
            Count++;
        }

        public int Peek()
        {
            return data[Count-1];
        }

        public int Pop()
        {
            int dataAtLastIndex = data[Count-1];
            data[Count-1] = default(int);
            return dataAtLastIndex;
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(data[i]);
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
    }
}
