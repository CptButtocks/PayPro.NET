using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PayPro.NET.Model
{
    public class ErrorResponse
    {
        [JsonPropertyName("return")]
        public string Return { get; set; } = String.Empty;
        [JsonPropertyName("errors")]
        public string Errors { get; set; } = String.Empty;

        public bool HasErrors => Errors == "true";
    }
}
