using System;
using System.Collections.Generic;

namespace Lib
{
    public class MyCollection<T>
    {
        private List<T> list; 

        public int Size
        {
            get
            {
                return list.Count;
            }
        }

        public MyCollection()
        {
            list = new List<T>();
        }

        public void Add(T newItem)
        {
            list.Add(newItem);
        }

        public T this[int index]
        {
            get
            {
                if (index > list.Count) throw new ArgumentOutOfRangeException();
                return list[index];
            }
        }
    }
}
