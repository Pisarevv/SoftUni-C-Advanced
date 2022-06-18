using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T>: IEnumerable<T>
    {
        private List<T> collection;
        private int currIndex;

        public ListyIterator(params T[] data)
        {
            this.collection = new List<T>(data);
            this.currIndex = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(T element in this.collection)
            {
                yield return element;
            }
        }

        public bool HasNext()
        {
            return currIndex < this.collection.Count-1;
        }

        public bool Move()
        {
            bool canMove = HasNext();
            if (canMove)
            {
                currIndex++;
            }
            return canMove;
        }

        public void Print()
        {
            if (collection.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
                return;
            }
            Console.WriteLine(collection[currIndex]);
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ", collection));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
