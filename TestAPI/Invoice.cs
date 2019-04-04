using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestAPI
{
    class Invoice
    {
        public async System.Threading.Tasks.Task CreateInvoice(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://10.3.56.3/api/v1/invoices");

            request.ContentType = "application/json";
            request.Method = "POST";
            request.Headers.Add("X-Ninja-Token", "dmgzavwittk5tfvpfqljtdoosvts2psh");

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"client_id\": \"" + id + "\", \"discount\": \"0\", \"due_date\": \"2020-05-12\", \"invoice_items\":[{\"id\": \"222\", \"product_key\": \"test\", \"cost\": \"12\", \"qty\": \"15\"}]}";

                streamWriter.Write(json);
            }

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public async System.Threading.Tasks.Task GetInvoice(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/invoices/{id}");

            request.ContentType = "application/json";
            request.Method = "GET";
            request.Headers.Add("X-Ninja-Token", "dmgzavwittk5tfvpfqljtdoosvts2psh");

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
            }
        }

        public async System.Threading.Tasks.Task GetInvoices()
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/invoices/");

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

        public async System.Threading.Tasks.Task UpdateInvoice(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/invoices/{id}");

            request.ContentType = "application/json";
            request.Method = "PUT";
            request.Headers.Add("X-Ninja-Token", "dmgzavwittk5tfvpfqljtdoosvts2psh");

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"client_id\": \"" + id + "\", \"discount\": \"0\", \"due_date\": \"2020-05-12\", " +
                    "\"invoice_items\":[{\"account_key\": \"oxdyllwo7ofqrwxbxw2ieyggjriuu0ug\",\"id\": \"5\", \"product_key\": \"test\", \"cost\": \"1\", \"qty\": \"1\"}],";


                streamWriter.Write(json);
            }
        }
        public async System.Threading.Tasks.Task DeleteInvoice(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/invoices/{id}?action=delete");

            request.ContentType = "application/json";
            request.Method = "PUT";
            request.Headers.Add("X-Ninja-Token", "dmgzavwittk5tfvpfqljtdoosvts2psh");

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }
        public async System.Threading.Tasks.Task ArchiveInvoice(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/invoices/{id}?action=archive");

            request.ContentType = "application/json";
            request.Method = "PUT";
            request.Headers.Add("X-Ninja-Token", "dmgzavwittk5tfvpfqljtdoosvts2psh");

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }
        public async System.Threading.Tasks.Task RestoreInvoice(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/invoices/{id}?action=restore");

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