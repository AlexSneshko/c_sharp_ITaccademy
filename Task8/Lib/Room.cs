using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class Room
    {
        private Printer printer;

        public Room(Printer printer)
        {
            this.printer = printer;
        }

        public void MakeThisLazyPrinterWork(string value)
        {
            printer.Print(value);
        }

        public void UpdatePrinter(Printer newPrinter)
        {
            printer = newPrinter;
        }
    }
}
