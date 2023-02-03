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
    }

    public class PauseSubscriptionRequest : SubscriptionRequest
    {

    }

    public class ResumeSubscriptionRequest : SubscriptionRequest
    {

    }

    public class CancelSubscriptionRequest : SubscriptionRequest
    {

    }
}
