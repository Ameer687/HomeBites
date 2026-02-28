using HomeBites.Data;
using HomeBites.Models;
using HomeBites.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HomeBites.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionsController : ControllerBase
    {
        private readonly ISubscriptionService _subscriptionService;

        public SubscriptionsController(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(Subscription sub)
        {
            var result = await _subscriptionService.CreateSubscription(sub);
            return Ok(result);
        }

        [HttpPost("trial")]
        public async Task<IActionResult> Trial(Subscription sub)
        {
            var result = await _subscriptionService.TrialSubscription(sub);
            return Ok(result);
        }
    }


}
