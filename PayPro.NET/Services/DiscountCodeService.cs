using PayPro.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPro.NET.Services
{
    public class DiscountCodeService : PayProService
    {
        public DiscountCodeService(string key) : base(key)
        {
        }

        public async Task<GetDiscountCodeResponse[]> GetAllDiscountCodes(GetDiscountCodesRequest request)
        {
            return await DoCommand<GetDiscountCodeResponse[]>("get_product_discount_codes", request);
        }

        public async Task<GetDiscountCodeResponse[]> GetDiscountCode(GetDiscountCodeRequest request)
        {
            return await DoCommand<GetDiscountCodeResponse[]>("get_product_discount_code", request);
        }
    }
}
