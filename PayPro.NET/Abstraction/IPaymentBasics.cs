using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPro.NET.Abstraction
{
    public interface IPaymentBasics
    {
        public bool HasIdeal { get; set; }
        public bool HasPaypal { get; set; }
        public bool HasMachtiging { get; set; }
    }
}
