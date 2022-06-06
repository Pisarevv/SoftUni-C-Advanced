using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class DoublyLinkedList
    {
        public int Count { get; private set; }
        public ListNode head { get; set; }
        public ListNode tail { get; set; }
        public void AddHead(int value)
        {
            if (Count == 0)
            {
                ListNode newHead = new ListNode(value);
                this.head = this.tail = newHead;
            }
            else
            {
                ListNode newHead = new ListNode(value);
                newHead.Next = this.head;
                this.head.Previous = newHead;
                this.head = newHead;

            }
            this.Count++;
        }

        public void AddTail(int value)
        {
            if (Count == 0)
            {
                ListNode newTail = new ListNode(value);
                this.head = this.tail = newTail;
            }
            else
            {
                ListNode newTail = new ListNode(value);
                this.tail.Next = newTail;
                newTail.Previous = this.tail;
                this.tail = newTail;
            }
            this.Count++;
        }

        public int RemoveFirst()
        {
            if (Count == 1)
            {
                this.tail = this.head = this.head.Next;
                this.head.Previous = null;
                return head.Value;
            }
            else
            {
                ListNode toRemove = this.head;
                this.head.Next.Previous = null;
                this.head = this.head.Next;
                Count--;
                return head.Value;
            }

        }

        public int RemoveLast()
        {
            if (Count == 1)
            {
                this.tail = this.head = this.tail.Previous;
                this.tail.Previous = null;
                this.tail.Next = null;
                return head.Value;
            }
            else
            {
                ListNode toRemove = this.tail;
                this.tail.Previous.Next = null;
                this.tail = this.tail.Previous;
                Count--;
                return tail.Value;
            }
        }

        public void ForEach(Action<int> action)
        {
            var currentNode = this.head;
            while(currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public int[] ToArray()
        {
            int[] createdArray = new int[Count];
            var currentNode = this.head;
            int elementCounter = 0;
            while (currentNode != null)
            {
                createdArray[elementCounter] = currentNode.Value;
                elementCounter++;
                currentNode = currentNode.Next;
            }
            return createdArray;
        }




        public class ListNode
        {
            public int Value;
            public ListNode Next;
            public ListNode Previous;

            public ListNode(int value)
            {
                this.Value = value;
            }
        }
    }
}
