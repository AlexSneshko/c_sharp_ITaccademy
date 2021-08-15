using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class Car : IMovable
    {
        public string Name { get; }

        public Car(string name)
        {
            Name = name;
        }

        public string Move()
        {
            return "Car is riding";
        }

        public override string ToString()
        {
            return String.Format("Car - \"{0}\"", Name);
        }
    }
}
