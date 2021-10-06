using System;
using System.Collections;
using System.Collections.Generic;

namespace MODULE3HW1
{
    public class CustomComparator<T> : IComparer<T>
    where T : IComparable<T>
    {
        public int Compare(T x, T y)
        {
            return x.CompareTo(y);
        }
    }
}