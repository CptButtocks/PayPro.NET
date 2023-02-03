using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PayPro.NET.Model
{
    public class CreateRefundRequest
    {
        [JsonPropertyName("sale_id")]
        public int SaleId { get; set; }
        [JsonPropertyName("sequence_number")]
        public int SequenceNumber { get; set; }
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        public CreateRefundRequest(int saleId)
        {
            SaleId = saleId;
        }
    }
}
