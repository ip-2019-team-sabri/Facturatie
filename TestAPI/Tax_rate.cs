using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestAPI
{
    class Tax_rate
    {
        public async System.Threading.Tasks.Task CreateTaxrate()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://10.3.56.3/api/v1/tax_rates");

            request.ContentType = "application/json";
            request.Method = "POST";
            request.Headers.Add("X-Ninja-Token", "dmgzavwittk5tfvpfqljtdoosvts2psh");

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{" +
                    "\"id\":\"1\"," +
                    "\"name\":\"GST\"," +
                    "\"account_key\":\"accountkeytest\"," +
                    "\"rate\":\"17.5\"," +
                    "\"updated_at\":\"2016-01-01 12:10:00\"," +
                    "\"archived_at\":\"2016-01-01 12:10:00\"," +
                    "}";
                streamWriter.Write(json);
            }
            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public async System.Threading.Tasks.Task GetTaxrates()
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://http://10.3.56.3/api/v1/tax_rates/");

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

        public async System.Threading.Tasks.Task UpdateTax(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/tax_rates/{id}");

            request.ContentType = "application/json";
            request.Method = "PUT";
            request.Headers.Add("X-Ninja-Token", "dmgzavwittk5tfvpfqljtdoosvts2psh");

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"id\":\"taxchange\",\"name\":\"GST2\"}";
                streamWriter.Write(json);
            }

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }
    }
}
