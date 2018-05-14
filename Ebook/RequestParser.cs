using Flurl.Http;
using System.Collections.Generic;
using System.Linq;

namespace Ebook
{
    class RequestParser
    {
        public string url = "https://www.s-vfu.ru/raspisanie/ajax.php";

        public string action, type, date;

        string responseString;

        string outString="";

        public RequestParser(string _action, string _type)
        {
            action = _action;
            type = _type;
        }

        public RequestParser(string _action, string _type, string _date)
        {
            action = _action;
            type = _type;
            date = _date;
        }

        public async System.Threading.Tasks.Task<string> requestAsync()
        {
            if (date == null)
            {
                responseString = await url
                .PostUrlEncodedAsync(new { action = action, fac = type, })
                .ReceiveString();
            }
            else
            {
                responseString = await url
                .PostUrlEncodedAsync(new { action = action, groupname = type, mydate = date})
                .ReceiveString();
            }
            return parser(responseString);
        }

        public string parser(string response)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(responseString);

            List<List<string>> table = doc.DocumentNode.SelectSingleNode("//table[@class='rasp table table-hover table-bordered']")
                        .Descendants("tr")
                        .Skip(1)
                        .Where(tr => tr.Elements("td").Count() > 1)
                        .Select(tr => tr.Elements("td").Select(td => td.InnerText.Trim()).ToList())
                        .ToList();
            for (int i = 0; i < table.Count; i++)
                for (int j = 0; j < table[i].Count; j++)
                    outString += table[i][j].ToString();
            System.IO.File.WriteAllText(@"C:\Users\Student\Desktop\ParseText.txt", responseString);
            return outString;
        }
    }
}
