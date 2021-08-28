using System;
using System.Collections.Generic;
using System.Text;

namespace Task12
{
    public class Title
    {
        public Categories Category { get; }

        public string Article { get; }

        public string Info { get; }

        public Title(Categories category, string article, string info)
        {
            Category = category;
            Article = article;
            Info = info;
        }
    }
}
