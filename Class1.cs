using System;

namespace nullable_generic
{
    public class Class1
    {
//#nullable enable
        public static bool Foo<TKey, TValue>(TKey key, TValue value, out TKey? output)
               where TKey : class
        {
            throw new System.NotImplementedException ();
        }
    }
}
