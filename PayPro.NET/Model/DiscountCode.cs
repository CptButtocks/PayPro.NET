using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PayPro.NET.Model
{
    public class GetDiscountCodesRequest
    {
        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }

        public GetDiscountCodesRequest(int productId)
        {
            ProductId = productId;
        }
    }

    public class GetDiscountCodeRequest
    {
        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }
        [JsonPropertyName("discount_code")]
        public string DiscountCode { get; set; }

        public GetDiscountCodeRequest(int productId, string discountCode)
        {
            ProductId = productId;
            DiscountCode = discountCode;
        }
    }

    public class GetDiscountCodeResponse
    {
        [JsonPropertyName("valid_until")]
        DateTime? ValidUntil { get; set; }
        [JsonPropertyName("allperiods")]
        public bool AllPeriods { get; set; }
        [JsonPropertyName("valid_times")]
        public int ValidTimes { get; set; } = -1;
        [JsonPropertyName("discount_percentage")]
        public int DiscountPercentage { get; set; }
        [JsonPropertyName("started_from")]
        public DateTime StartedFrom { get; set; }
        [JsonPropertyName("only_for_affiliates")]
        public bool OnlyForAffiliates { get; set; }
        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }
        [JsonPropertyName("valid_from")]
        public DateTime? ValidFrom { get; set; }
        [JsonPropertyName("active")]
        public bool Active { get; set; }
        [JsonPropertyName("code")]
        public string Code { get; set; } = String.Empty;
        [JsonPropertyName("discount_cents")]
        public int DiscountCents { get; set; }
    }
}
