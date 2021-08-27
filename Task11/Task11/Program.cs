using System;

namespace Task11
{
    class Program
    {
        static void Print(MyList list)
        {
            Console.WriteLine("List");
            foreach (var item in list)
                Console.WriteLine(item);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var list = new MyList();
            var item1 = new MyItem("Item1");
            var item2 = new MyItem("Item2");
            var item3 = new MyItem("Item3");
            var item4 = new MyItem("Item4");

            list.Add(item1);
            list.Add(item2);
            list.Add(item3);
            list.Add(item4);
            Print(list);

            list.Remove(item2);
            Print(list);

            list.RemoveAt(2);
            Print(list);

            list.Insert(1, new MyItem("newItem"));
            Print(list);
        }
    }
}
