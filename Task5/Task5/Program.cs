using System;
using ClassLibrary;

namespace Task5
{
    class Program
    {

        static void program1()
        {
            int[] array = { 1, 5, 6, 4, 6, 7, 8, 2 };

            ArrayWorker.ToString(array);
            ArrayWorker.Reverse(array);
            ArrayWorker.ToString(array);
            ArrayWorker.Add(ref array, 2, 100);
            ArrayWorker.ToString(array);
        }

        static void program2()
        {
            Cone cone = new Cone(2, 3);
            Console.WriteLine(cone.ToString());
        }

        static void Main(string[] args)
        {
            //program1();
            program2();
        }
    }
}
