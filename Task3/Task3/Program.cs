using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.141592653;
            double r, l;
            Console.Write("Print r: ");
            r = Double.Parse(Console.ReadLine());
            Console.Write("Print l: ");
            l = Double.Parse(Console.ReadLine());

            Console.WriteLine("S = {0}", pi * r * (r + l));
        }
    }
}
