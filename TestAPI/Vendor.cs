using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestAPI
{
    class Vendor
    {
        public async System.Threading.Tasks.Task CreateVendor()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://10.3.56.3/api/v1/vendors");

            request.ContentType = "application/json";
            request.Method = "POST";
            request.Headers.Add("X-Ninja-Token", "tgbtqob1pvsizhmoc9i5foinrpe1chdr");

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                //AAN TE PASSEN
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

        public async System.Threading.Tasks.Task GetVendor(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/vendors/{id}");

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

        public async System.Threading.Tasks.Task GetVendors()
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/vendors/");

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

        public async System.Threading.Tasks.Task UpdateVendor(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/vendors/{id}");

            request.ContentType = "application/json";
            request.Method = "PUT";
            request.Headers.Add("X-Ninja-Token", "tgbtqob1pvsizhmoc9i5foinrpe1chdr");

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                //AAN TE PASSEN
                string json = "{\"name\":\"Client1\",\"contact\":{\"id\":\"{id}\"}}";
                streamWriter.Write(json);
            }

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public async System.Threading.Tasks.Task ArchiveVendor(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/vendors/{id}?action=archive");

            request.ContentType = "application/json";
            request.Method = "PUT";
            request.Headers.Add("X-Ninja-Token", "tgbtqob1pvsizhmoc9i5foinrpe1chdr");

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
            request.Headers.Add("X-Ninja-Token", "tgbtqob1pvsizhmoc9i5foinrpe1chdr");

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public async System.Threading.Tasks.Task RestoreVendor(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/vendors/{id}?action=restore");

            request.ContentType = "application/json";
            request.Method = "PUT";
            request.Headers.Add("X-Ninja-Token", "tgbtqob1pvsizhmoc9i5foinrpe1chdr");

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }


    }
}