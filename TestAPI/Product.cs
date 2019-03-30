using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace TestAPI
{
    class Product
    {
        public async System.Threading.Tasks.Task CreateProduct()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://10.3.56.3/api/v1/products");

            request.ContentType = "application/json";
            request.Method = "POST";
            request.Headers.Add("X-Ninja-Token", "dmgzavwittk5tfvpfqljtdoosvts2psh");

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{" +
                    "\"id\":\"1\"," +
                    "\"product_key\":\"product\"," +
                    "\"notes\":\"note1\"," +
                    "\"cost\":\"20000\"}";

                streamWriter.Write(json);
            }
            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

    public async System.Threading.Tasks.Task GetProducts()
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/products/");

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

    public async System.Threading.Tasks.Task UpdateProduct(int id)
    {
        var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/products/{id}");

        request.ContentType = "application/json";
        request.Method = "PUT";
        request.Headers.Add("X-Ninja-Token", "dmgzavwittk5tfvpfqljtdoosvts2psh");

        using (var streamWriter = new StreamWriter(request.GetRequestStream()))
        {
            string json = "{\"id\":\"2\",\"product_key\":\"product 2\"}";
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
