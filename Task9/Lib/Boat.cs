using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class Boat : IMovable
    {
        public string Name { get; }

        public Boat(string name)
        {
            Name = name;
        }

        public string Move()
        {
            return "Boat is sailng";
        }

        public override string ToString()
        {
            return String.Format("Boat - \"{0}\"", Name);
        }
    }
}
