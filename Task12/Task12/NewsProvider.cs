using System;
using System.Collections.Generic;
using System.Text;

namespace Task12
{
    public class NewsProvider
    {
        private Action<Title> NewsMailing;
        private Action<Title> WeatherMailing;
        private Action<Title> SportMailing;
        private Action<Title> IncidentMailing;
        private Action<Title> HumorMailing;

        public event Action<Title> Mailing
        {
            add
            {
                var client = value.Target as Client;

                if (client.HasCategory(Categories.News)) NewsMailing += value;
                if (client.HasCategory(Categories.Weather)) WeatherMailing += value;
                if (client.HasCategory(Categories.Sport)) SportMailing += value;
                if (client.HasCategory(Categories.Incident)) IncidentMailing += value;
                if (client.HasCategory(Categories.Humor)) HumorMailing += value;
            }
            remove
            {
                var client = value.Target as Client;

                if (client.HasCategory(Categories.News)) NewsMailing -= value;
                if (client.HasCategory(Categories.Weather)) WeatherMailing -= value;
                if (client.HasCategory(Categories.Sport)) SportMailing -= value;
                if (client.HasCategory(Categories.Incident)) IncidentMailing -= value;
                if (client.HasCategory(Categories.Humor)) HumorMailing -= value;
            }
        }

        public void SendTitle(Title title)
        {
            Console.WriteLine(new string('=', 25));
            Console.WriteLine("Sending title {0}", title.Category);
            Console.WriteLine(new string('-', 25));

            switch (title.Category)
            {
                case Categories.News: NewsMailing(title); break;
                case Categories.Weather: WeatherMailing(title); break;
                case Categories.Sport: SportMailing(title); break;
                case Categories.Incident: IncidentMailing(title); break;
                case Categories.Humor: HumorMailing(title); break;
                default: break;
            }

            Console.WriteLine(new string('-', 25));
            Console.WriteLine("Title sent");
            Console.WriteLine(new string('=', 25));
        }

    }
}
