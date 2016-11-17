using System;
using System.Collections;
using System.Collections.Generic;

namespace BlogDataStructures
{
    public class MyDirectAccessList : IList<int>
    {
        private int[] _arr;
        private int nextIdx = 0;
        private const int INITIAL_SIZE = 50;
        private const int SIZE_MULTIPLIER = 2;

        public int this[int index]
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

        public void Add(int item)
        {
            if(_arr == null)
            {
                _arr = new int[INITIAL_SIZE];
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

        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(int item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, int item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int item)
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