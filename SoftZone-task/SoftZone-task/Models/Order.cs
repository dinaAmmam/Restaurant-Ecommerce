using System.ComponentModel.DataAnnotations.Schema;

namespace SoftZone_task.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int? SubTotal { get; set; }
        public int? Total { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer? Customer{ get; set; }
        public virtual ICollection<Item> Items { get; set; } = new HashSet<Item>();

    }
}
