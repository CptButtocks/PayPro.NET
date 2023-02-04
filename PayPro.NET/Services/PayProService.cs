using PayPro.NET.Model;
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
        private readonly JsonSerializerOptions _serializerOptions = new JsonSerializerOptions()
        {
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
        };
        private const string _baseUrl = "https://paypro.nl/post_api";
        public PayProService(string key)
        {
            _apiKey = key;
        }

        protected async Task<T> DoCommand<T>(string command, object parameters)
        {
            using (HttpClient client = new HttpClient())
            {
                string parameterBody = JsonSerializer.Serialize(parameters, options: _serializerOptions);
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("apikey", _apiKey),
                    new KeyValuePair<string, string>("command", command),
                    new KeyValuePair<string, string>("params", parameterBody)
                });

                HttpResponseMessage response = await client.PostAsync(_baseUrl, content);
                string responseString = await response.Content.ReadAsStringAsync();
                ErrorResponse? errors = JsonSerializer.Deserialize<ErrorResponse>(responseString);
                if (errors != null && errors.HasErrors)
                    throw new Exception(errors.Return);
                T? deserializeObject = JsonSerializer.Deserialize<T>(responseString);
                if (deserializeObject == null)
                    throw new ArgumentNullException("The resulting object could not be deserialized");

                return deserializeObject;
            }
        }
    }
}
