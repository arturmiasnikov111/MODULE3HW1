using System;
using System.Collections;
using System.Collections.Generic;

namespace MODULE3HW1
{
    public class Starter
    {
        public void Run()
        {
            SuperList<int> sp = new SuperList<int>();
            List<int> lst = new List<int>();
            lst.Add(20);
            lst.Add(30);
            sp.Add(1222);
            sp.Add(2);
            sp.Add(222);
            sp.RemoveAt(0);
            sp.Remove(2);
            sp.Add(2000);
            sp.AddRange(lst);
            sp.Add(11);
            int[] arr = new int[sp.Size];
            sp.CopyTo(arr, 0);
            sp.Sort(new CustomComparator<int>());
            foreach (var item in sp)
            {
                Console.WriteLine(item);
            }
        }
    }
}