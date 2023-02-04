using PayPro.NET.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PayPro.NET.Model
{
    public class CreateProductRequest : IPaymentBasics
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }
        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("has_ideal")]
        public bool HasIdeal { get; set; }
        [JsonPropertyName("has_paypal")]
        public bool HasPaypal { get; set; }
        [JsonPropertyName("has_machtiging")]
        public bool HasMachtiging { get; set; }
        [JsonPropertyName("is_editable")]
        public bool IsEditable { get; set; }
        [JsonPropertyName("goods_type")]
        public string GoodsType { get; set; } = "digital";

        public CreateProductRequest(string title,string url, string description, string returnUrl, int price)
        {
            Title = title;
            Url = url;
            Description = description;
            ReturnUrl = returnUrl;
            Price = price;
        }
    }

    public class GetProductRequest
    {
        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }
    }

    public class ProductResponse : IPaymentBasics
    {
        [JsonPropertyName("number_of_periods")]
        public string NumberOfPeriods { get; set; } = String.Empty;
        [JsonPropertyName("score")]
        public int Score { get; set; }
        [JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; } = String.Empty;
        [JsonPropertyName("price")]
        public int Price { get; set; }
        [JsonPropertyName("time_multiplier")]
        public string TimeMultiplier { get; set; } = String.Empty;
        [JsonPropertyName("name")]
        public string Name { get; set; } = String.Empty;
        [JsonPropertyName("has_paypal")]
        public bool HasPaypal { get; set; }
        [JsonPropertyName("has_bancontact")]
        public bool HasBanConctact { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; } = String.Empty;
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
        [JsonPropertyName("time_type")]
        public string TimeType { get; set; } = String.Empty;
        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; }
        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }
        [JsonPropertyName("has_ideal")]
        public bool HasIdeal { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; } = String.Empty;
        [JsonPropertyName("has_machtiging")]
        public bool HasMachtiging { get; set; }
    }

    public class UpdateProductRequest
    {
        private string _parameter { get; set; }
        private string[] _allowedParameters = new string[]
        {
            "name",
            "url",
            "description",
            "return_url",
            "has_machtiging",
            "has_ideal",
            "has_bancontact",
            "has_paypal",
            "has_sofort",
            "goods_type",
            "price_c",
            "affiliate_commission_c",
            "is_editable",
            "vat",
            "form_return_companyname",
            "form_return_name",
            "form_return_address",
            "form_return_phone",
            "form_return_remarks",
            "form_return_mobile",
            "form_return_password",
            "form_return_firstlastname"
        };

        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }
        [JsonPropertyName("parameter")]
        public string Parameter
        {
            get => _parameter;
            set
            {
                if (_allowedParameters.Contains(value))
                    _parameter = value;
                else
                    throw new ArgumentException($"parameter: {value} is not considered a valid parameter for a product update");
            }
        }
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class DeleteProductRequest
    {
        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }
    }
}
