using System.ComponentModel.DataAnnotations.Schema;

namespace SoftZone_task.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int? Price { get; set; }

        [ForeignKey("Menu")]
        public int MenuId { get; set; }
        public virtual Menu? Menu { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();


    }
}
