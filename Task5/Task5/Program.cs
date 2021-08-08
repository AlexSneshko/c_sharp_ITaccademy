using System;
using ClassLibrary;

namespace Task5
{
    //class ArrayWorker
    //{
    //    public static int[] Reverse(int[] input)
    //    {
    //        Array.Reverse(input);
    //        return input;
    //    }

    //    public static void ToString(int[] input)
    //    {
    //        for (int i = 0; i < input.Length; i++)
    //            Console.Write("{0}, ", input[i]);
    //        Console.WriteLine();
    //    }

    //    public static void Add(ref int[] source, int index, int newValue)
    //    {
    //        Array.Resize<int>(ref source, source.Length + 1);

    //        for (int i = source.Length - 1; i > index; i--)
    //            source[i] = source[i - 1];
    //        source[index] = newValue;
    //    }
    //}

   

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
