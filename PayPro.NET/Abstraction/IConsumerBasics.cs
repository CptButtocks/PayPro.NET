using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPro.NET.Abstraction
{
    public interface IConsumerBasics
    {
        public string ConsumerAddress { get; set; }
        public string ConsumerCity { get; set; }
        public string ConsumerCountry { get; set; }
        public string ConsumerEmail { get; set; }
        public string ConsumerPostal { get; set; }
    }
}
