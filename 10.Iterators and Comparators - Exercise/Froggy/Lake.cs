using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    internal class Lake : IEnumerable<int>
    {
        private List<int> list;
        public Lake(params int[] data)
        {
            this.List = new List<int>(data);
        }
        public List<int> List { get => list; set => list = value; }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    yield return list[i];
                }
            }

            for (int i = this.list.Count - 1; i >= 0; i--)
            {
                if (list[i] % 2 == 0)
                {
                    yield return list[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
