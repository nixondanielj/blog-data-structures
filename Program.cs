using System;
using System.Collections.Generic;

namespace BlogDataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for(int n = 0; n < 100; n++)
            {
                IList<int> list = new MyDirectAccessList<int>();
                TestAddItemNTimes(list, 1, n);
            }
            for(int n = 0; n < 100; n++)
            {
                IList<string> list = new MyDirectAccessList<string>();
                TestAddItemNTimes(list, "dog", n);
            }
            Console.ReadKey();
        }

        public static void TestAddItemNTimes<T>(IList<T> list, T item, int n)
        {
            int prevCount = list.Count;
            for(int i = 0; i < n; i++)
            {
                list.Add(item);
            }
            if(list.Count - prevCount == n)
            {
                Console.WriteLine($"SUCCESS for n={n}: Add incremented Count!");
            }
            else
            {
                Console.WriteLine($"FAILED for n={n}: Add did not increment count");
            }
        }
    }
}
