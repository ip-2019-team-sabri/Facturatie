using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestAPI
{
    class Document
    {
        public async System.Threading.Tasks.Task CreateDocument()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://10.3.56.3/api/v1/documents");

            request.ContentType = "application/json";
            request.Method = "POST";
            request.Headers.Add("X-Ninja-Token", "dmgzavwittk5tfvpfqljtdoosvts2psh");

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"pagination\":{\"total\":\"0\",\"count\":\"0\",\"per_page\":\"15\",\"current_page\":\"3\",\"total_pages\":\"0\"}}";

                streamWriter.Write(json);
            }
            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public async System.Threading.Tasks.Task GetDocuments()
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/documents/");

            request.ContentType = "application/json";
            request.Method = "GET";
            request.Headers.Add("X-Ninja-Token", "dmgzavwittk5tfvpfqljtdoosvts2psh");

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}
