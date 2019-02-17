using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUsingHTMLAgilityPack
{
    // Program to load html page from web using HTMLAgilityPack
    class Program
    {
        static void Main()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("http://www.c-sharpcorner.com");

            //Console.WriteLine(document.DocumentNode.OuterHtml);

            //var node = document.DocumentNode.SelectSingleNode("//head/title");

            //Console.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);

            //var titles = document.DocumentNode.SelectNodes("//a[@class='title']").ToList();

            //foreach(var title in titles)
            //{
            //    Console.WriteLine(title.InnerText);
            //}

            // Prints all the author names of the Recent Posts
            var htmlNodes = document.DocumentNode.SelectNodes("//a[@class='author']").ToArray();

            foreach(var node in htmlNodes)
            {
                Console.WriteLine(node.InnerHtml);
            }
        }
    }
}
