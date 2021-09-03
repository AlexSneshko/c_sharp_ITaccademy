using System;
using System.Collections.Generic;
using System.Text;

namespace Task13
{
    class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }

        public override string ToString() => $"Mагазина с названием {Message} не существует";  
    }
}
