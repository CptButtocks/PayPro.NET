using PayPro.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPro.NET.Services
{
    public class InvoiceService : PayProService
    {
        public InvoiceService(string key) : base(key)
        {

        }

        public async Task<CreateInvoiceResponse> CreateInvoice(CreateInvoiceRequest request)
        {
            return await DoCommand<CreateInvoiceResponse>("create_invoice", request);
        }
    }
}
