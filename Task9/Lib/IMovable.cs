using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public interface IMovable 
    {
        string Name { get; }
        string Move();
    }
}
