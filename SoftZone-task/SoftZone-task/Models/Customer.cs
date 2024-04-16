using System.ComponentModel.DataAnnotations.Schema;

namespace SoftZone_task.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();

    }
}
