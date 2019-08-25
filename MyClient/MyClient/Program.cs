using System;
using MyCodeLibrary;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebPage("http://google.com");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
