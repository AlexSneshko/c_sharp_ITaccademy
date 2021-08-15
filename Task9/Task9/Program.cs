using System;
using Lib;

namespace Task9
{
    class Program
    {
        public static void printCollection<T>(MyCollection<T> collection)
        {
            Console.WriteLine("{0} collection", collection.ToString());
            for(int i = 0; i < collection.Size; i++)
                Console.WriteLine(collection[i].ToString());
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var car1 = new Car("car1");
            var car2 = new Car("car2");
            var car3 = new Car("car3");
            var car4 = new Car("car4");

            var boat1 = new Boat("boat1");
            var boat2= new Boat("boat2");
            var boat3 = new Boat("boat3");
            var boat4 = new Boat("boat4");

            //Cars
            MyCollection<Car> myCollectionCars = new MyCollection<Car>();
            myCollectionCars.Add(car1);
            myCollectionCars.Add(car2);
            myCollectionCars.Add(car3);
            myCollectionCars.Add(car4);
            printCollection<Car>(myCollectionCars);

            //Boats
            MyCollection<Boat> myCollectionBoats = new MyCollection<Boat>();
            myCollectionBoats.Add(boat1);
            myCollectionBoats.Add(boat2);
            myCollectionBoats.Add(boat3);
            myCollectionBoats.Add(boat4);
            printCollection<Boat>(myCollectionBoats);

            //Cars and boats
            MyCollection<IMovable> myCollection = new MyCollection<IMovable>();
            myCollection.Add(boat1);
            myCollection.Add(car1);
            myCollection.Add(boat2);
            myCollection.Add(car2);
            myCollection.Add(car3);
            myCollection.Add(boat3);
            myCollection.Add(boat4);
            myCollection.Add(car4);
            printCollection<IMovable>(myCollection);
        }
    }
}
