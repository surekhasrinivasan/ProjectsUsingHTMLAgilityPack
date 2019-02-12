using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadHTMLFromWeb
{
    // Program to show HTMLWeb.Load method gets an HTML document from Web 
    class Program
    {
        static void Main()
        {
            var html = @"http://html-agility-pack.net/";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");

            Console.WriteLine("Node name: " + node.Name + "\n" + node.OuterHtml);            
        }
    }
}
