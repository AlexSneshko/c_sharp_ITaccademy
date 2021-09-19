using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Task17
{
    class Car
    {
        public int Age { get; set; }
        public Car(int age) => Age = age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            var timer = new Stopwatch();

            for (int i = 0; i < 100000000; i++)
                cars.Add(new Car(i));

            timer.Start();
            foreach (var car in cars)
                car.Age = (343 * 34 * 2 * 77) / 567;
            Console.WriteLine("Foreach: {0}", timer.ElapsedTicks);
            timer.Restart();

            for (int i = 0; i < cars.Count; i++)
                cars[i].Age = (343 * 34 * 2 * 77) / 567;
            Console.WriteLine("For: {0}", timer.ElapsedTicks);
            timer.Restart();

            Parallel.ForEach(cars, car => car.Age = (343 * 34 * 2 * 77) / 567);
            Console.WriteLine("Parallel.ForEach: {0}", timer.ElapsedTicks);
            timer.Restart();

            Parallel.For(0, cars.Count, i => cars[i].Age = (343 * 34 * 2 * 77) / 567);
            Console.WriteLine("Parallel.For: {0}", timer.ElapsedTicks);
            timer.Stop();
        }
    }
}
