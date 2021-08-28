using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsProvider = new NewsProvider();
            //users
            var alex = new Client("Alex", Categories.News);
            var danik = new Client("Danik", Categories.Weather);
            var petya = new Client("Petya", Categories.Sport);
            var sasha = new Client("Sasha", Categories.Incident);
            var masha = new Client("Masha", Categories.Humor);
            var katya = new Client("Katya", Categories.News);
            //titles
            var title1 = new Title(Categories.News, "title1", "Info 1");
            var title2 = new Title(Categories.Sport, "title2", "Info 2");
            var title3 = new Title(Categories.Weather, "title3", "Info 3");
            var title4 = new Title(Categories.Incident, "title4", "Info 4");
            var title5 = new Title(Categories.Humor, "title5", "Info 5");
            
            danik.AddCategory(Categories.News);
            danik.AddCategory(Categories.Sport);
            danik.AddCategory(Categories.Humor);
            masha.AddCategory(Categories.Incident);
            katya.AddCategory(Categories.Incident);

            newsProvider.Mailing += alex.GetTitle;
            newsProvider.Mailing += danik.GetTitle;
            newsProvider.Mailing += petya.GetTitle;
            newsProvider.Mailing += sasha.GetTitle;
            newsProvider.Mailing += masha.GetTitle;
            newsProvider.Mailing += katya.GetTitle;

            newsProvider.SendTitle(title1);
            newsProvider.SendTitle(title2);
            newsProvider.SendTitle(title3);
            newsProvider.SendTitle(title4);
            newsProvider.SendTitle(title5);
        }
    }
}
