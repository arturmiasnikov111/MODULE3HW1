using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MODULE3HW1
{
    public class SuperList<T> : ICollection<T>
    {
        private T[] _data;
        public SuperList()
        {
            Size = 0;
            Count = 0;
            Capacity = 1;
            _data = new T[Capacity];
        }

        public int Capacity { get; private set; }

        public int Count { get; set; }

        public object SyncRoot { get; }

        public bool IsReadOnly { get; }

        public bool IsSynchronized { get; }

        public int Size { get; private set; }

        public T this[int index]
        {
            get { return _data[index]; }
            set { _data[index] = value; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Size; i++)
            {
                yield return _data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // call the generic version of the method
            return GetEnumerator();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            if (Size + 1 < _data.Length)
            {
                _data[Size] = item;
                Size++;
                Count++;
            }
            else
            {
                ResizeArrayAndAdd(ref _data, item);
            }
        }

        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var item in collection)
                {
                    Add(item);
                }
        }

        public bool Remove(T item)
        {
            int index = Array.IndexOf(_data, item, 0);
            RemoveAt(index);
            Count--;
            return true;
        }

        public void RemoveAt(int index)
        {
            Size--;
            Count--;
            Array.Copy(_data, index + 1, _data, index, Size - index);
        }

        public void Sort()
        {
            Array.Sort(_data, 0, Size);
        }

        public void Sort(IComparer<T> comparer)
        {
            Array.Sort(_data, 0, Size, comparer);
        }

        public void Clear()
        {
            _data = new T[1];
            Size = 0;
            Capacity = 1;
            Count = 0;
        }

        public void CopyTo(T[] array, int index)
        {
            Array.Copy(_data, 0, array, index, Size);
        }

        private void ResizeArrayAndAdd(ref T[] items, T item)
        {
            Capacity = Capacity * 2;
            Array.Resize(ref items, Capacity);
            Add(item);
        }
    }
}