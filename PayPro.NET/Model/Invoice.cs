using PayPro.NET.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PayPro.NET.Model
{
    public class CreateInvoiceRequest : IConsumerBasics
    {
        [JsonPropertyName("amount")]
        public int Amount { get; set; }
        [JsonPropertyName("consumer_address")]
        public string ConsumerAddress { get; set; }
        [JsonPropertyName("consumer_city")]
        public string ConsumerCity { get; set; }
        [JsonPropertyName("consumer_country")]
        public string ConsumerCountry { get; set; }
        [JsonPropertyName("consumer_email")]
        public string ConsumerEmail { get; set; }
        [JsonPropertyName("consumer_postal")]
        public string ConsumerPostal { get; set; }
        [JsonPropertyName("invoicemethod")]
        public string InvoiceMethod { get; set; }
        [JsonPropertyName("affiliate_amount")]
        public int AffiliateAmount { get; set; }
        [JsonPropertyName("amount_n")]
        public int? AmountNext { get; set; }
        [JsonPropertyName("approve_machtiging")]
        public string? ApproveMachtiging { get; set; }
        [JsonPropertyName("consumer_accountno")]
        public string? ConsumerAccountNumber { get; set; }
        [JsonPropertyName("consumer_companyname")]
        public string? ConsumerCompanyName { get; set; }
        [JsonPropertyName("consumer_Name")]
        public string? ConsumerName { get; set; }
        [JsonPropertyName("consumer_phone")]
        public string? ConsumerPhone { get; set; }
        [JsonPropertyName("consumer_vatnumber")]
        public string? ConsumerVATNumber { get; set; }
        [JsonPropertyName("custom")]
        public string? Custom { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        [JsonPropertyName("periods_frequency")]
        public int? PeriodFrequency { get; set; }
        [JsonPropertyName("periods_multiplier")]
        public int? PeriodsMultiplier { get; set; }
        [JsonPropertyName("periods_type")]
        public string? PeriodsType { get; set; }
        [JsonPropertyName("postback_url")]
        public string? PostbackUrl { get; set; }
        [JsonPropertyName("remarks")]
        public string? Remarks { get; set; }
        [JsonPropertyName("return_url")]
        public string? ReturnUrl { get; set; }
        [JsonPropertyName("vat")]
        public int? VAT { get; set; }

        public CreateInvoiceRequest(int amount, string consumerAddress, string consumerCity, string consumerCountry, string consumerEmail, string consumerPostal, string invoiceMethod)
        {
            Amount = amount;
            ConsumerAddress = consumerAddress;
            ConsumerCity = consumerCity;
            ConsumerCountry = consumerCountry;
            ConsumerEmail = consumerEmail;
            ConsumerPostal = consumerPostal;
            InvoiceMethod = invoiceMethod;
        }
    }

    public class CreateInvoiceResponse
    {
        [JsonPropertyName("sale_id")]
        public int SaleId { get; set; }
        [JsonPropertyName("payment_url")]
        public string PaymentUrl { get; set; } = String.Empty;
        [JsonPropertyName("payment_hash")]
        public string PaymentHash { get; set; } = String.Empty;
    }
}
