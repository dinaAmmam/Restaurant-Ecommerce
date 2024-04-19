using SoftZone_task.DTOS.Customer;
using SoftZone_task.DTOS.Restaurant;

namespace SoftZone_task.DTOS.Item
{
    public record ItemReadDto
    {
        public int ItemId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int? Price { get; set; }
        public RestaurantChlidReadDto restaurant { get; set; }

    }
}
