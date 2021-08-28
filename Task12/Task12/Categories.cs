using System;
using System.Collections.Generic;
using System.Text;

namespace Task12
{
    [Flags]
    public enum Categories : byte
    {
        News = 1,
        Weather = 2, 
        Sport = 4,
        Incident = 8,
        Humor = 16
    }
}
