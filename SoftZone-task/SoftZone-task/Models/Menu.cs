using System.ComponentModel.DataAnnotations.Schema;

namespace SoftZone_task.Models
{
    public class Menu
    {
        public int MenuId { get; set; }

        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
        public virtual Restaurant? Restaurant { get; set; }
        public virtual ICollection<Item> Items { get; set; } = new HashSet<Item>();



    }
}

//using System.ComponentModel.DataAnnotations.Schema;

//namespace SoftZone_task.Models
//{
//    public class Menu
//    {
//        public int MenuId { get; set; }

//        [ForeignKey("Restaurant")]
//        public int RestaurantId { get; set; }
//        public virtual Restaurant Restaurant { get; set; }
//        public virtual ICollection<Item> Items { get; set; } = new HashSet<Item>();
//    }
//}