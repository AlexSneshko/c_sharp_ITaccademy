using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Print number: ");
            int a = Int32.Parse(Console.ReadLine());

            if (a >= 0 && a <= 30)
            {
                Console.WriteLine("1st interval 0-30");
            } else if (a >= 31 && a <= 60)
            {
                Console.WriteLine("2nd interval 31-60");
            }
            else if (a >= 61 && a <= 100)
            {
                Console.WriteLine("2nd interval 61-100");
            }
            else
            {
                Console.WriteLine("Unidentified number");
            }
        }
    }
}
