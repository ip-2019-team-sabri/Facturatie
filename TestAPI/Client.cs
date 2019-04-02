using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestAPI
{
    class Client
    {
        public async System.Threading.Tasks.Task CreateClient()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://10.3.56.3/api/v1/clients");

            request.ContentType = "application/json";
            request.Method = "POST";
            request.Headers.Add("X-Ninja-Token", "dmgzavwittk5tfvpfqljtdoosvts2psh");

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"id\":\"1\",\"name\":\"Freestyle\"," +
                    "\"contact\":{\"first_name\":\"Tim\",\"last_name\":\"Van den Borre\",\"email\":\"tim.van.den.borre@student.ehb.be\"}}";
                streamWriter.Write(json);
            }
            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public async System.Threading.Tasks.Task GetClient(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/clients/{id}");

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

        public async System.Threading.Tasks.Task GetClients()
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/clients/");

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

        public async System.Threading.Tasks.Task UpdateClient(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/clients/{id}");

            request.ContentType = "application/json";
            request.Method = "PUT";
            request.Headers.Add("X-Ninja-Token", "dmgzavwittk5tfvpfqljtdoosvts2psh");

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"name\":\"Client1\",\"contact\":{\"id\":\"{id}\"}}";
                streamWriter.Write(json);
            }

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public async System.Threading.Tasks.Task ArchiveClient(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/clients/{id}?action=archive");

            request.ContentType = "application/json";
            request.Method = "PUT";
            request.Headers.Add("X-Ninja-Token", "dmgzavwittk5tfvpfqljtdoosvts2psh");

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public async System.Threading.Tasks.Task DeleteClient(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/clients/{id}?action=delete");

            request.ContentType = "application/json";
            request.Method = "PUT";
            request.Headers.Add("X-Ninja-Token", "dmgzavwittk5tfvpfqljtdoosvts2psh");

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public async System.Threading.Tasks.Task RestoreClient(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/clients/{id}?action=restore");

            request.ContentType = "application/json";
            request.Method = "PUT";
            request.Headers.Add("X-Ninja-Token", "dmgzavwittk5tfvpfqljtdoosvts2psh");

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }
    }
}