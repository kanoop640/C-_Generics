using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Student<T>
    {
        List<T> arr = new List<T>();
        public void Add(T a)
        {
            arr.Add(a);
        }
        public T get(int index)
        {
            return arr[index];
        }
        public void show()
        {
            for(int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(get(i));
            }
        }
        public void insert(int i, T a)
        {
            arr.Insert(i, a);
        }
        public void sort()
        {
            arr.Sort();
            show();
        }
    }
}
