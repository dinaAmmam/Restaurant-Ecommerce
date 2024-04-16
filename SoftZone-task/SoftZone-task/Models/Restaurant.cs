using System.ComponentModel.DataAnnotations.Schema;

namespace SoftZone_task.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string? RestaurantName { get; set; }
        public string? RestaurantDescription { get; set; }
        public string? Image {  get; set; }

        [ForeignKey("Menu")]
        public int? MenuId { get; set; }
        public virtual Menu? Menu { get; set; }


    }
}

//using System.ComponentModel.DataAnnotations.Schema;

//namespace SoftZone_task.Models
//{
//    public class Restaurant
//    {
//        public int RestaurantId { get; set; }
//        public string? RestaurantName { get; set; }
//        public string? RestaurantDescription { get; set; }
//        public string? Image { get; set; }

//        public virtual ICollection<Menu> Menus { get; set; } = new HashSet<Menu>();
//    }
//}