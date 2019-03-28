using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestAPI
{
    class Task_rates
    {
        public async System.Threading.Tasks.Task CreateTaxrate()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://10.3.56.3/api/v1/tax_rates");

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

        public async System.Threading.Tasks.Task UpdateTax(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"http://10.3.56.3/api/v1/tax_rates/{id}");

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
    }
}