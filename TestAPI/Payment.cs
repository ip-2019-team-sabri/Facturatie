using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace TestAPI
{
    class Payment
    {
        // Voor we een payment aanamaken moeten we een invoice hebben!!!
        public async System.Threading.Tasks.Task CreatePayment()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://http://10.3.56.3/api/v1/payments");

            request.ContentType = "application/json";
            request.Method = "POST";
            request.Headers.Add("X-Ninja-Token", "dmgzavwittk5tfvpfqljtdoosvts2psh");

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{" +
                    "\"id\":\"1\", " +
                    "\"amount\":\"10\"," +
                    "\"transaction_reference\":\"ref\", " +
                    "\"payment_date\":\"2019-03-30\"," +
                    "\"updated_at\":\"1553940612\"," +
                    "\"payment_type_id\":\"14\"," +
                    "\"invoice_id\":\"1\"," +
                    "\"invoice_number\":\"0001\"," +
                    "\"private_notes\":\"private\"," +
                    "\"exchange_rate\":\"1\"," +
                    "\"exchange_rate\":\"1\"," +
                    "\"exchange_currency_id\":\"122\"}";
                streamWriter.Write(json);
            }
            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public async System.Threading.Tasks.Task GetPayments()
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/payments/");

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

        public async System.Threading.Tasks.Task UpdatePayment(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/payments/{id}");

            request.ContentType = "application/json";
            request.Method = "PUT";
            request.Headers.Add("X-Ninja-Token", "dmgzavwittk5tfvpfqljtdoosvts2psh");

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"id\":\"{id}\"}";
                streamWriter.Write(json);
            }

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public async System.Threading.Tasks.Task DeletePayment(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/payments/{id}?action=delete");

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
