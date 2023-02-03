using PayPro.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPro.NET.Services
{
    public class RefundService : PayProService
    {
        public RefundService(string key) : base(key)
        {

        }

        public async Task<string> CreateRefund(CreateRefundRequest request)
        {
            return await DoCommand<string>("refund", request);
        }
    }
}
