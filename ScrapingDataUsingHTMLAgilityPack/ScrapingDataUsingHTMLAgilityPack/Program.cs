using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapingDataUsingHTMLAgilityPack
{
    class Program
    {
        static void Main()
        {
            HtmlWeb web = new HtmlWeb();

            //var html = @"https://www.google.com/search?q=book&source=lnms&tbm=bks&sa=X&ved=0ahUKEwjc_dHmyrngAhUHPN8KHYRaDPAQ_AUIDygC&biw=1366&bih=657";

            var htmlDoc = web.Load("http://www.yellowpages.com/search?search_terms=Software&geo_location_terms=Sydney2C+ND");

            var Titles = htmlDoc.DocumentNode.SelectNodes("//a[@class='business-name']").ToList();

            foreach(var item in Titles)
                Console.WriteLine(item.InnerText);
        }
    }
}
