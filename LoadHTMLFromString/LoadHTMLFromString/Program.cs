﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadHTMLFromString
{
    class Program
    {
        static void Main()
        {
            var html =
                @"<!DOCTYPE html>
                <html>
                <body>
	                <h1>This is <b>bold</b> heading</h1>
	                <p>This is <u>underlined</u> paragraph</p>
	                <h2>This is <i>italic</i> heading</h2>
                </body>
                </html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            Console.WriteLine(htmlBody.OuterHtml);
        }
    }
}
