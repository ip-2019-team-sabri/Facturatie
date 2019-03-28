using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestAPI
{
    class Credit
    {
        public async System.Threading.Tasks.Task CreateCredit(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://10.3.56.3/api/v1/credits");

            request.ContentType = "application/json";
            request.Method = "POST";
            request.Headers.Add("X-Ninja-Token", "if66tlj6cn2xam4dvctx72ak1q4jhjcq");

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"amount\": \"10\", \"private_notes\": \"Add Money\",\"public_notes\": \"Money\",\"client_id\": \"" + id + "\"}";

                streamWriter.Write(json);
            }

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public async System.Threading.Tasks.Task GetCredit(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/credits/{id}");

            request.ContentType = "application/json";
            request.Method = "GET";
            request.Headers.Add("X-Ninja-Token", "if66tlj6cn2xam4dvctx72ak1q4jhjcq");

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
            }
        }

        public async System.Threading.Tasks.Task UpdateCredit(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/credits/{id}");

            request.ContentType = "application/json";
            request.Method = "PUT";
            request.Headers.Add("X-Ninja-Token", "if66tlj6cn2xam4dvctx72ak1q4jhjcq");

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"amount\":\"15\",\"private_notes\":\"money\",\"public_notes\":\"Money\",\"client_id\":\"2\"}";

                streamWriter.Write(json);
            }
        }
        public async System.Threading.Tasks.Task DeleteCredit(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/credits/{id}?action=delete");

            request.ContentType = "application/json";
            request.Method = "PUT";
            request.Headers.Add("X-Ninja-Token", "if66tlj6cn2xam4dvctx72ak1q4jhjcq");

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }
        public async System.Threading.Tasks.Task ArchiveCredit(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/credits/{id}?action=archive");

            request.ContentType = "application/json";
            request.Method = "PUT";
            request.Headers.Add("X-Ninja-Token", "if66tlj6cn2xam4dvctx72ak1q4jhjcq");

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }
        public async System.Threading.Tasks.Task RestoreCredit(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/credits/{id}?action=restore");

            request.ContentType = "application/json";
            request.Method = "PUT";
            request.Headers.Add("X-Ninja-Token", "if66tlj6cn2xam4dvctx72ak1q4jhjcq");

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }
    }
}
