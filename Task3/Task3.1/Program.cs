using System;

namespace Task3._1
{
    class Program
    {
        static void Main(string[] args)
        {                                                                                                                                      
            int x = 14, y = 1, z = 5;

            x += y - x++ * z;
            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
            z = --x - y * 5; 
            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
            y /= x + 5 % z;
            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
            z = x++ + y * 5;
            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
            x = y - x++ * z;
            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
        }
    }
}
