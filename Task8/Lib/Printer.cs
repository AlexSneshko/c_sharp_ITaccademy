using System;

namespace Lib
{
    public abstract class Printer
    {
        public virtual void Print(string value)
        { 
            Console.WriteLine(value);
        }
    }
}
