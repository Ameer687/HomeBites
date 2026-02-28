namespace HomeBites.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int VendorId { get; set; }
        public string SubscriptionType { get; set; }
        public DateTime StartDate { get; set; }
    }

}
