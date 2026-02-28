using HomeBites.Models;
namespace HomeBites.Services.Interfaces
{
    

    public interface ISubscriptionService
    {
        Task<Subscription> CreateSubscription(Subscription sub);
        Task<Subscription> TrialSubscription(Subscription sub);
    }

}
