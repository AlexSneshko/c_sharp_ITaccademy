using System;

namespace tester
{
    class Program
    {
        static void Main(string[] args)
        {
            int nailsAmount, hitsAmount;
            Console.Write("Print amount of nail: ");
            nailsAmount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Amount of hits: ");
            hitsAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int nails = nailsAmount;
            while (nails > 0)
            {
                for(int i = 0; i < hitsAmount; i++)
                    Console.WriteLine("Hit");
                Console.WriteLine("{0} nail done\n", nailsAmount - nails + 1);
                nails--;
            }
        }
    }
}
