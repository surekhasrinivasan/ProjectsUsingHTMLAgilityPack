using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadPageFromSavedDocument
{
    // Program to load page from saved document 
    class Program
    {
        static void Main()
        {
            HtmlDocument document = new HtmlDocument();
            document.Load(@"C:\Users\sreen\source\repos\HTMLAgilityPackProjects\LoadPageFromSavedDocument\Sample.txt");

            var nodes = document.DocumentNode.SelectNodes("//a").ToArray();
            foreach(var node in nodes)
            {
                Console.WriteLine(node.InnerHtml);
            }
        }
    }
}
