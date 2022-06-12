using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01._Box_of_T
{
    public class Box<T>
    {
        private List<T> data;
        public int Count { get { return this.data.Count; } }
        public Box()
        {
            data = new List<T>();
        }

        public void Add(T item)
        {
            this.data.Add(item);
        }

        public T Remove()
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("The box is empty");
            }
            var lastElement = this.data[this.data.Count - 1];
            this.data.RemoveAt(this.data.Count - 1);
            return lastElement;
        }

        
       
    }
}
