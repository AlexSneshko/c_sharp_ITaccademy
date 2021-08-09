using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public static class IntExtension
    {
        public static void SortByIncreasing(this int[] numbers)
        {
            for(int i = 0; i < numbers.Length - 1; i++)
                for (int j = i + 1; j < numbers.Length; j++)
                    if(numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }

        }

        public static string ToString(this int[] array, int on)
        {
            StringBuilder result = new StringBuilder();

            foreach (var number in array)
                result.Append(number.ToString() + " ");

            return result.ToString();
        }
    }
}
