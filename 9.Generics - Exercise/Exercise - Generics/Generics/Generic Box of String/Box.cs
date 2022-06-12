using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Box<T>
    {
        public List<T> data { get; set; }

        public Box()
        {
            data = new List<T>();
        }

        public void Swap(int index1, int index2)
        {
            T firstData = data[index1];
            data[index1] = data[index2];
            data[index2] = firstData;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Count; i++)
            {
                sb.Append($"{data[i].GetType()}: {data[i]}" + "\n");
            }         
            return sb.ToString();
        }

    }
}
