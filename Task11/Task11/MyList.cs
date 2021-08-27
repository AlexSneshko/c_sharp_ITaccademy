using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task11
{
    class MyList : IList<MyItem>
    {
        private MyItem[] myItems;

        public MyList()
        {
            myItems = new MyItem[0];
        }

        public MyItem this[int index] { get => myItems[index]; set => myItems[index] = value; }

        public int Count => myItems.Length;

        public bool IsReadOnly => myItems.IsReadOnly;

        public void Add(MyItem item)
        {
            Array.Resize(ref myItems, myItems.Length + 1);
            myItems[^1] = item;
        }

        public void Clear()
        {
            myItems = new MyItem[0]; 
        }

        public bool Contains(MyItem item)
        {
            foreach (var it in myItems)
                if (it == item)
                    return true;
            return false;
        }

        public void CopyTo(MyItem[] array, int arrayIndex)
        {
            myItems.CopyTo(array, arrayIndex);
        }

        public IEnumerator<MyItem> GetEnumerator()
        {
            foreach (var item in myItems)
                yield return item;
        }   

        public int IndexOf(MyItem item)
        {
            return Array.IndexOf(myItems, item);
        }

        public void Insert(int index, MyItem item)
        {
            Array.Resize(ref myItems, myItems.Length + 1);

            for (int i = index; i < myItems.Length - 1; i++)
                myItems[i + 1] = myItems[i];
            myItems[index] = item;
        }

        public bool Remove(MyItem item)
        {
            int index = Array.IndexOf(myItems, item);

            if (index == -1) return false;
            RemoveAt(index);
            return true;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < myItems.Length - 1; i++)
                myItems[i] = myItems[i + 1];
            Array.Resize(ref myItems, myItems.Length - 1);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
