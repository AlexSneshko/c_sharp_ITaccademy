using System;

namespace Task4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 201, finish = 500;

            while(start < finish)
            {
                if (start % 17 == 0)
                    Console.Write("{0}, ", start);
                start++;
            }
        }
    }
}
