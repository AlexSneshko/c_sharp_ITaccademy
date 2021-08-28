using System;
using System.Collections.Generic;
using System.Text;

namespace Task12
{
    public class Client
    {
        public string Name { get; }
        private Categories Categories { get; set; }

        public Client(string name, Categories categories)
        {
            Name = name;
            Categories = categories;
        }

        public void AddCategory(Categories category)
        {
            Categories |= category;
        }

        public bool HasCategory(Categories category)
        {
            return Categories.HasFlag(category);
        }

        public void GetTitle(Title title)
        {
            Console.WriteLine("Client {0} \nTitle {1} with info: \n{2}\n", Name, title.Article, title.Info);
        }
    }
}
