using System;
using Lib;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            var greenPrinter = new GreenPrinter();
            var bluePrinter = new BluePrinter();
            var room = new Room(greenPrinter);

            room.MakeThisLazyPrinterWork("var room = new Room(new GreenPrinter());\n");

            room.UpdatePrinter(bluePrinter);
            room.MakeThisLazyPrinterWork("var room = new Room(new GreenPrinter());\n");
        }
    }
}
