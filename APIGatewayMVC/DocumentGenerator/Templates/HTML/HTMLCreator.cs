using System.Collections.Generic;

namespace DocumentGenerator.Templates.HTML
{
    public class HtmlCreator: IHtmlCreator
    {
        public string Create(string title, IEnumerable<string> headers, IEnumerable<IEnumerable<string>> tableValues)
        {
            string htmlDocument = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\" xml:lang=\"en\" lang=\"en\">\r\n  <head>\r\n    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n    <title>file_1688467542626</title>\r\n    <style type=\"text/css\">\r\n      * {\r\n        margin: 0;\r\n        padding: 0;\r\n        text-indent: 0;\r\n      }\r\n      .s1 {\r\n        color: #fff;\r\n        font-family: \"Trebuchet MS\", sans-serif;\r\n        font-style: normal;\r\n        font-weight: normal;\r\n        text-decoration: none;\r\n  padding: 8px;      font-size: 11pt;\r\n      }\r\n      .s2 {\r\n        color: black;\r\n        font-family: \"Trebuchet MS\", sans-serif;\r\n        font-style: normal;\r\n        font-weight: normal;\r\n        text-decoration: none;\r\n        font-size: 10pt;\r\n      }\r\n      .s3 {\r\n        color: black;\r\n        font-family: \"Trebuchet MS\", sans-serif;\r\n        font-style: normal;\r\n        font-weight: normal;\r\n        text-decoration: none;\r\n        font-size: 10pt;\r\n      }\r\n      p {\r\n        color: black;\r\n        font-family: \"Trebuchet MS\", sans-serif;\r\n        font-style: normal;\r\n        font-weight: normal;\r\n        text-decoration: none;\r\n        font-size: 15pt;\r\n        margin: 0pt;\r\n      }\r\n      table,\r\n      tbody {\r\n        vertical-align: top;\r\n        overflow: visible;\r\n      }\r\n    </style>\r\n  </head>\r\n  <body>\r\n\r\n\t<p style=\"padding-top: 3pt;padding-left: 143pt;text-indent: 0pt;text-align: center;\">";
            htmlDocument = htmlDocument + title;
            htmlDocument = htmlDocument + "</p>\r\n\t<p style=\"text-indent: 0pt;text-align: left;\"><br/></p>\r\n\r\n    <table style=\"border-collapse: collapse\" cellspacing=\"0\">\r\n      <tr style=\"height: 30pt\">";

            string tableHeader = null;
            foreach (string header in headers)
            {
                tableHeader = tableHeader + "        <td bgcolor=\"#2D4154\">\r\n          <p\r\n            class=\"s1\"\r\n            style=\"padding-top: 1pt; text-indent: 0pt; text-align: left\"\r\n          >\r\n            " + header + "\r\n          </p>\r\n        </td>";
            }
            htmlDocument = htmlDocument + tableHeader;

            string tableLines = null;

            foreach (var tableValue in tableValues)
            {
                tableLines = tableLines + "      <tr style=\"height: 28pt\">";
                foreach (string value in tableValue)
                {
                    tableLines = tableLines + "        <td bgcolor=\"#F3F3F3\">\r\n          <p\r\n            class=\"s2\"\r\n            style=\"padding-top: 1pt; text-indent: 0pt; text-align: left\"\r\n          >\r\n            " + value + "\r\n          </p>\r\n        </td>";
                }
                tableLines = tableLines + "      </tr>";
            }
            htmlDocument = htmlDocument + tableLines + "    </table>\r\n  </body>\r\n</html>";

            return htmlDocument;

        }
    }
}
