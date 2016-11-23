using System;
using System.Collections;
using System.Collections.Generic;

namespace BlogDataStructures
{
    public class MyDirectAccessList<T> : IList<T>
    {
        private T[] _arr;
        private int nextIdx = 0;
        private const int INITIAL_SIZE = 50;
        private const int SIZE_MULTIPLIER = 2;

        public T this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Count
        {
            get
            {
                return nextIdx;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(T item)
        {
            if(_arr == null)
            {
                _arr = new T[INITIAL_SIZE];
            }
            else if(nextIdx >= _arr.Length)
            {
                Array.Resize(ref _arr, _arr.Length * SIZE_MULTIPLIER);
            }
            _arr[nextIdx] = item;
            nextIdx++;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}