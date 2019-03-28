using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestAPI
{
    class Documents
    {
        public async System.Threading.Tasks.Task CreateDocument()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://10.3.56.3/api/v1/documents");

            request.ContentType = "application/json";
            request.Method = "POST";
            request.Headers.Add("X-Ninja-Token", "tgbtqob1pvsizhmoc9i5foinrpe1chdr");

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                //AAN TE PASSEN NOG
                string json = "{\"id\":\"103\",\"name\":\"Brol3\"," +
                    "\"contact\":{\"first_name\":\"brol2\",\"last_name\":\"brol3\",\"email\":\"lena.maas@student.ehb.be\"}}";
                streamWriter.Write(json);
            }
            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public async System.Threading.Tasks.Task GetDocument(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/documents/{id}");

            request.ContentType = "application/json";
            request.Method = "GET";
            request.Headers.Add("X-Ninja-Token", "tgbtqob1pvsizhmoc9i5foinrpe1chdr");

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }

        public async System.Threading.Tasks.Task GetDocumentss()
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/documents/");

            request.ContentType = "application/json";
            request.Method = "GET";
            request.Headers.Add("X-Ninja-Token", "tgbtqob1pvsizhmoc9i5foinrpe1chdr");

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
