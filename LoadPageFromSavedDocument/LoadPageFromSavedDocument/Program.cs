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

            // prints all the hyperlinks from the Sample.txt document
            //var nodes = document.DocumentNode.SelectNodes("//a").ToArray();
            //foreach(var node in nodes)
            //{
            //    Console.WriteLine(node.InnerHtml);
            //}

            // Prints specific div from the Sample.txt document
            var node = document.DocumentNode.SelectNodes("//div[@id='div1']").First();

            Console.WriteLine(node.InnerText);

        }
    }
}
