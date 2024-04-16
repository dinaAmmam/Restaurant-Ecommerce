using SoftZone_task.DTOS.Menu;
using SoftZone_task.Models;
namespace SoftZone_task.DTOS.Restaurant
{
    public record RestaurantReadDto
    {
        public int RestaurantId { get; set; }
        public string? RestaurantName { get; set; }
        public string? RestaurantDescription { get; set; }
        public string? Image { get; set; }
        public int? MenuId { get; set; }

        //public MenuChlidReadDto Menu { get; set; }
    }
}
