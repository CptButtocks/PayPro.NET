using PayPro.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace PayPro.NET.Services
{
    public class PaymentMethodService : PayProService
    {
        public PaymentMethodService(string key) : base(key)
        {
        }

        public async Task<JsonObject> GetPaymentMethods()
        {
            return await DoCommand<JsonObject>("get_all_pay_methods", new object());
        }

        public async Task<JsonObject> GetPaymentMethods(GetPaymentMethodRequest request)
        {
            return await DoCommand<JsonObject>("get_pay_methods", request);
        }
    }
}
