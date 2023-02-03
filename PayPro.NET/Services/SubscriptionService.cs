using PayPro.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPro.NET.Services
{
    public class SubscriptionService : PayProService
    {
        public SubscriptionService(string key) : base(key)
        {
        }

        public async Task<string> PauseSubscription(int saleId)
        {
            return await DoCommand<string>("pause_subscription", new PauseSubscriptionRequest(saleId));
        }

        public async Task<string> ResumeSubscription(int saleId)
        {
            return await DoCommand<string>("resume_subscription", new ResumeSubscriptionRequest(saleId));
        }

        public async Task<string> CancelSubscription(int saleId)
        {
            return await DoCommand<string>("cancel_subscription", new CancelSubscriptionRequest(saleId));
        }
    }
}
