using System;
using System.Collections.Generic;
using System.Text;

namespace Task11
{
    class MyItem
    {
        public string Name { get; set; }

        public MyItem(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("MyItem name: {0}", Name);
        }
    }
}
