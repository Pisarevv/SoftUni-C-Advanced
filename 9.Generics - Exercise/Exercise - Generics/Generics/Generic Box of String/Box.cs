using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Box_of_String
{
    internal class Box<T>
    {
        public T data { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{data.GetType()}: {data}");
            return sb.ToString();
        }
    }
}
