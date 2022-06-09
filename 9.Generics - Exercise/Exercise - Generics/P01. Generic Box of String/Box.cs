using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01._Generic_Box_of_String
{
    public class Box<T>
    {
        private T element;

        public T Element
        {
            get { return element; }
            set { element = value; }
        }

        public Box(T element)
        {
            Element = element;
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {Element}";
        }
    }
}
