using System.ComponentModel.DataAnnotations;

namespace HomeBites.Models
{
    public class Vendor
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string BusinessName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
    }

}
