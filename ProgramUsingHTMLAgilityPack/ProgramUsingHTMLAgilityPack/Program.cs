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

            var node = document.DocumentNode.SelectSingleNode("//head/title");

            Console.WriteLine(node.Name +"\n" + node.OuterHtml);
        }
    }
}
