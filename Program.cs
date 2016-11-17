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
                IList<int> list = new MyDirectAccessList();
                TestAddItemNTimes(list, 1, n);
            }
            Console.ReadKey();
        }

        public static void TestAddItemNTimes(IList<int> list, int item, int n)
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
