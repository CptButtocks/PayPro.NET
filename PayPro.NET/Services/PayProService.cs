using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PayPro.NET.Services
{
    public abstract class PayProService
    {
        private readonly string _apiKey;
        private const string _baseUrl = "https://paypro.nl/post_api";
        public PayProService(string key)
        {
            _apiKey = key;
        }

        protected async Task<T> DoCommand<T>(string command, object parameters)
        {
            using (HttpClient client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("apikey", _apiKey),
                    new KeyValuePair<string, string>("command", command),
                    new KeyValuePair<string, string>("params", JsonSerializer.Serialize(parameters))
                });

                HttpResponseMessage response = await client.PostAsync(_baseUrl, content);
                string responseString = await response.Content.ReadAsStringAsync();
                T? deserializeObject = JsonSerializer.Deserialize<T>(responseString);
                if (deserializeObject == null)
                    throw new ArgumentNullException("The resulting object could not be deserialized");

                return deserializeObject;
            }
        }
    }
}
