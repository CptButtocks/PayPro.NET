using PayPro.NET.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PayPro.NET.Model
{
    public class CreatePaymentRequest : IConsumerBasics
    {
        [JsonPropertyName("amount")]
        int Amount { get; set; }
        [JsonPropertyName("affiliate_amount")]
        public string? AffiliateAmount { get; set; }
        [JsonPropertyName("approve_machtiging")]
        public string? ApproveMachtiging { get; set; }
        [JsonPropertyName("cancel_url")]
        public string? CancelUrl { get; set; }
        [JsonPropertyName("consumer_accountno")]
        public string? ConsumerAccountNumber { get; set; }
        [JsonPropertyName("consumer_address")]
        public string? ConsumerAddress { get; set; }
        [JsonPropertyName("consumer_city")]
        public string? ConsumerCity { get; set; }
        [JsonPropertyName("consumer_companyname")]
        public string? ConsumerCompanyName { get; set; }
        [JsonPropertyName("consumer_country")]
        public string? ConsumerCountry { get; set; }
        [JsonPropertyName("consumer_email")]
        public string? ConsumerEmail { get; set; }
        [JsonPropertyName("consumer_firstname")]
        public string? ConsumerFirstName { get; set; }
        [JsonPropertyName("consumer_mobile")]
        public string? ConsumerMobile { get; set; }
        [JsonPropertyName("consumer_name")]
        public string? ConsumerName { get; set; }
        [JsonPropertyName("consumer_phone")]
        public string? ConumerPhone { get; set; }
        [JsonPropertyName("consumer_postal")]
        public string? ConsumerPostal { get; set; }
        [JsonPropertyName("consumer_vatnumber")]
        public string? ConsumerVATNumber { get; set; }
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }
        [JsonPropertyName("custom")]
        public string? Custom { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        [JsonPropertyName("locale")]
        public string? Locale { get; set; }
        [JsonPropertyName("next_direct_debit_date")]
        public DateTime NextDirectDebitDate { get; set; }
        [JsonPropertyName("pay_method")]
        public string? PayMethod { get; set; }
        [JsonPropertyName("postback_url")]
        public string? PostBackUrl { get; set; }
        [JsonPropertyName("remarks")]
        public string? Remarks { get; set; }
        [JsonPropertyName("return_url")]
        public string? ReturnUrl { get; set; }
        [JsonPropertyName("test_mode")]
        public bool? TestMode { get; set; }
        [JsonPropertyName("vat")]
        public int? VAT { get; set; }
    }

    public class CreatePaymentResponse
    {
        [JsonPropertyName("payment_url")]
        public string PaymentUrl { get; set; } = String.Empty;
        [JsonPropertyName("payment_hash")]
        public string PaymentHash { get; set; } = String.Empty;
    }

    public class CreateProductPaymentRequest : CreatePaymentRequest
    {
        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }
        [JsonPropertyName("consumer_email")]
        new public string ConsumerEmail { get; set; }
    }

    public class GetPaymentRequest
    {
        [JsonPropertyName("payment_hash")]
        public string PaymentHash { get; set; }
        [JsonPropertyName("sale_id")]
        public int SaleId { get; set; }
    }

    public class GetPaymentResposne
    {
        [JsonPropertyName("last_successful_seq")]
        public int LastSuccessfulSequence { get; set; }
        [JsonPropertyName("emailaddress")]
        public string EmailAddress { get; set; } = String.Empty;
        [JsonPropertyName("amount_total_affiliate")]
        public int AmounttotalAffiliate { get; set; }
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("total_paused_days")]
        public int TotalPausedDays { get; set; }
        [JsonPropertyName("current_number_of_periods")]
        public int CurrentNumberOfPeriods { get; set; }
        [JsonPropertyName("order_quantity")]
        public string OrderQuantity { get; set; } = String.Empty;
        [JsonPropertyName("total")]
        public string Total { get; set; } = String.Empty;
        [JsonPropertyName("number_of_periods")]
        public int NumberOfPeriods { get; set; }
        [JsonPropertyName("address")]
        public string Address { get; set; } = String.Empty;
        [JsonPropertyName("vatnumber")]
        public string VATNumber { get; set; } = String.Empty;
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; } = String.Empty;
        [JsonPropertyName("period_duration")]
        public string PeriodDuration { get; set; } = String.Empty;
        [JsonPropertyName("custom")]
        public string Custom { get; set; } = String.Empty;
        [JsonPropertyName("lastname")]
        public string Lastname { get; set; } = String.Empty;
        [JsonPropertyName("firstname")]
        public string Firstname { get; set; } = String.Empty;
        [JsonPropertyName("invoicemethod")]
        public string InvoiceMethod { get; set; } = String.Empty;
        [JsonPropertyName("current_status")]
        public string CurrentStatus { get; set; } = String.Empty;
        [JsonPropertyName("postal")]
        public string Postal { get; set; } = String.Empty;
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; } = String.Empty;
        [JsonPropertyName("vat")]
        public int VAT { get; set; }
        [JsonPropertyName("amount_affiliate_initial")]
        public int AmountAffiliateInitial { get; set; }
        [JsonPropertyName("amount_total")]
        public int AmountTotal { get; set; }
        [JsonPropertyName("price_recurring")]
        public int PriceRecurring { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; } = String.Empty;
        [JsonPropertyName("affiliate")]
        public object Affiliate { get; set; } = null!;
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
        [JsonPropertyName("amount_affiliate_recurring")]
        public int AmountAffiliateRecurring { get; set; }
        [JsonPropertyName("price_initial")]
        public int PriceInitial { get; set; }
        [JsonPropertyName("remarks")]
        public string Remarks { get; set; } = String.Empty;
        [JsonPropertyName("description")]
        public string Description { get; set; } = String.Empty;
        [JsonPropertyName("phone")]
        public string Phone { get; set; } = String.Empty;
        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }
    }
}
