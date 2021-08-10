using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class BluePrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
