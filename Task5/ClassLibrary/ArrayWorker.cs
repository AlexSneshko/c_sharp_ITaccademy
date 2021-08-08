using System;

namespace ClassLibrary
{
    public static class ArrayWorker
    {
        public static int[] Reverse(int[] input)
        {
            Array.Reverse(input);
            return input;
        }

        public static void ToString(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
                Console.Write("{0}, ", input[i]);
            Console.WriteLine();
        }

        public static void Add(ref int[] source, int index, int newValue)
        {
            Array.Resize<int>(ref source, source.Length + 1);

            for (int i = source.Length - 1; i > index; i--)
                source[i] = source[i - 1];
            source[index] = newValue;
        }
    }
}
