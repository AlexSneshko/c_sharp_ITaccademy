using System;

namespace Task7
{
    class Program
    {
        static void program1()
        {
            var array = new int[6];
            Console.WriteLine("Print a numbers: ");
            for (int i = 0; i < array.Length; i++)
                array[i] = int.Parse(Console.ReadLine());

            Array.Sort(array);
            Array.Reverse(array);

            foreach (var number in array)
                Console.Write($"{number} ");
        }

        static void program2()
        { 

            var array = new int[3, 3] { { 2, 7, 8 }, { 4, 1, 2 }, { 5, 6, 0 } };

            for(int i = 0; i <= array.GetUpperBound(0); i++)
            {
                int max = array[i, 0];

                for (int j = 0; j < array.Length / (array.GetUpperBound(0) + 1); j++)
                {
                    if (array[i, j] > max)
                        max = array[i, j];
                }

                Console.WriteLine($"Max in {i + 1} column: {max}");
            }

        }

        static void Main(string[] args)
        {
            //program1();
            program2();
        }
    }
}
