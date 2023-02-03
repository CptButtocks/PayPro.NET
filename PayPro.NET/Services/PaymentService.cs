using PayPro.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPro.NET.Services
{
    public class PaymentService : PayProService
    {
        public PaymentService(string key) : base(key)
        {
            
        }

        public async Task<CreatePaymentResponse> CreatePayment(CreatePaymentRequest request)
        {
            return await DoCommand<CreatePaymentResponse>("create_payment", request);
        }

        public async Task<CreatePaymentResponse> CreateProductPayment(CreateProductPaymentRequest request)
        {
            return await DoCommand<CreatePaymentResponse>("create_product_payment", request);
        }

        public async Task<GetPaymentResposne> GetPayment(GetPaymentRequest request)
        {
            return await DoCommand<GetPaymentResposne>("get_sale", request);
        }
    }
}
