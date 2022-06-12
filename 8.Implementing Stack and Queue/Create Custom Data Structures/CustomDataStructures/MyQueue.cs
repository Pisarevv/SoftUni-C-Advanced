using System;
namespace CustomDataStructures
{
    public class MyQueue
    {
        private int[] data;
        private const int STARTCAPACITY = 4;
        public int Count { get; private set; }

        public MyQueue()
        {
            this.data = new int[STARTCAPACITY];
            this.Count = 0;
        }


        public void Enqueue(int element)
        {
            if(this.Count + 1 == data.Length)
            {
                Resize();
            }
            ShiftRight();
            data[0] = element;
            this.Count++;
        }

        public int Dequeue()
        {
            int firstElement = data[0];
            ShiftLeft();
            this.Count--;
            return firstElement;
        }

        public int Peek()
        {
            return data[0];
        }

        public void Clear()
        {
            for (int i = 0; i < this.Count; i++)
            {
                data[i] = default(int);
            }
            this.Count = 0;
        }
        
        public void ForEach(Action <int> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(data[i]);
            }
        }


        public void Resize()
        {
            int newCapacity = data.Length * 2;
            int[] newArray = new int[newCapacity];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = data[i];
            }
            data = newArray;
        }

        public void ShiftRight()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                data[i+1] = data[i];
            }
        }

        public void ShiftLeft()
        {
            for (int i = 0; i < this.Count; i++)
            {
                data[i] = data[i+1];
            }
        }
    }
}
