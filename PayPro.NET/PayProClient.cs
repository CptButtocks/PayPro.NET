using PayPro.NET.Services;
using System.Text.Json;

namespace PayPro.NET
{
    public class PayProClient
    {
        public PaymentService Payments { get; }
        public ProductService Products { get; }
        public RefundService Refunds { get; }
        public InvoiceService Invoices { get; }
        public SubscriptionService Subscriptions { get; }
        public DiscountCodeService Discounts { get; }
        public PayProClient(string key)
        {
            Payments = new(key);
            Products = new(key);
            Refunds = new(key);
            Invoices = new(key);
            Subscriptions = new(key);
            Discounts = new(key);
        }
    }
}