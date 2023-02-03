using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PayPro.NET.Model
{
    public class GetPaymentMethodRequest
    {
        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }
    }
}
