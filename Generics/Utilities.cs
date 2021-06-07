using System;

namespace Generics
{
    // where T : IComparable - constraint to an interface
    // where T : Product - constraint to a given type or any sub classes
    // where T : struct - constraint to a value type
    // where T : class - constraint to a reference type
    // where T : new() - or to have a default constructor
    public class Utilities<T> where T : IComparable, new() // Constraint to an interface / to have a default constructor
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        //public T Max<T> (T a, T b) where T : IComparable
        public T Max(T a, T b)
        {
            //return a > b ? a : b;
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}