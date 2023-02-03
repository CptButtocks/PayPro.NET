using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PayPro.NET.Model
{
    public class SubscriptionRequest
    {
        [JsonPropertyName("sale_id")]
        public int SaleId { get; set; }
        public SubscriptionRequest(int saleId)
        {
            SaleId = saleId;
        }
    }

    public class PauseSubscriptionRequest : SubscriptionRequest
    {
        public PauseSubscriptionRequest(int saleId) : base(saleId)
        {

        }
    }

    public class ResumeSubscriptionRequest : SubscriptionRequest
    {
        public ResumeSubscriptionRequest(int saleId) : base(saleId)
        {

        }
    }

    public class CancelSubscriptionRequest : SubscriptionRequest
    {
        public CancelSubscriptionRequest(int saleId) : base(saleId)
        {

        }
    }
}
