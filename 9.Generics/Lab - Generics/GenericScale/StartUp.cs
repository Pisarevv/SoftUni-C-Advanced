using System;

namespace GenericScale
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> equalityScale = new EqualityScale<int>();
            var equals = EqualityScale<int>.AreEqual(1,1); 
        }
    }
}
