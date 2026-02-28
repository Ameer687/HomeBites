using HomeBites.Data;
using HomeBites.Models;
using HomeBites.Services.Interfaces;
namespace HomeBites.Services.Implementations
{
    

    public class SubscriptionService : ISubscriptionService
    {
        private readonly HomeBitesContext _context;

        public SubscriptionService(HomeBitesContext context)
        {
            _context = context;
        }

        public async Task<Subscription> CreateSubscription(Subscription sub)
        {
            sub.StartDate = DateTime.Now;

            _context.Subscriptions.Add(sub);
            await _context.SaveChangesAsync();

            return sub;
        }

        public async Task<Subscription> TrialSubscription(Subscription sub)
        {
            sub.SubscriptionType = "Trial";
            sub.StartDate = DateTime.Now;

            _context.Subscriptions.Add(sub);
            await _context.SaveChangesAsync();

            return sub;
        }
    }

}
