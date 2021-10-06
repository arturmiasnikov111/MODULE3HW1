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
            sp.Add(1222);
            sp.Add(2);
            List<int> lt = new List<int>();
            lt.Add(5);
            lt.Add(2);
            lt.Add(3);
            sp.AddRange(lt);
            sp.Sort(new CustomComparator<int>());
            sp.Clear();
            foreach (var item in sp)
            {
                Console.WriteLine(item);
            }
        }
    }
}