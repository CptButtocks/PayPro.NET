using PayPro.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPro.NET.Services
{
    public class ProductService : PayProService
    {
        public ProductService(string key) : base(key)
        {

        }

        public async Task<ProductResponse> CreateProduct(CreateProductRequest request)
        {
            return await DoCommand<ProductResponse>("create_product", request);
        }

        public async Task<ProductResponse> CreateProduct(GetProductRequest request)
        {
            return await DoCommand<ProductResponse>("get_product", request);
        }

        public async Task<string> CreateProduct(UpdateProductRequest request)
        {
            return await DoCommand<string>("create_product", request);
        }

        public async Task<bool> DeleteProduct(DeleteProductRequest request)
        {
            return await DoCommand<bool>("create_product", request);
        }
    }
}
