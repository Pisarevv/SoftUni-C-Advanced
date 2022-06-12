using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public  class EqualityScale<T>
    {
        public static bool AreEqual(T left, T right)
        {
            return left.Equals(right);
        }
    }
}
