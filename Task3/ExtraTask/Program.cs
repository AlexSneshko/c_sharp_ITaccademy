    using System;

namespace ExtraTask
{
    class Program
    {
        static int NOK(int number1, int number2)
        {
            if (number2 != 0)
                return NOK(number2, number1 % number2);
            return number1;
        }

        static int multiNOK(params int[] numbers)
        {
            int currentNOK = NOK(numbers[0], numbers[1]);

            for (int i = 2; i < numbers.Length; i++)
            {
                currentNOK = NOK(currentNOK, numbers[i]);
            }

            return currentNOK;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(multiNOK(225, 45, 135, 105, 60));
        }
    }
}
