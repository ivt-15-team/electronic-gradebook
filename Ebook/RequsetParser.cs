using System.Net;
using System.Text;
using System.IO;

namespace Ebook
{
    class RequsetParser
    {
        public string url = "http://s-vfu.ru/raspisanie/ajax.php";

        public string request(string _fac)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);

            var postData = "action=showgroups&fac=" + _fac ;
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return parser(responseString);       
        }

        public string parser(string response)
        {


            return response;
        }
    }
}
