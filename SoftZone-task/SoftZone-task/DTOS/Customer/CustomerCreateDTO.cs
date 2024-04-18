using SoftZone_task.DTOS.Item;
using SoftZone_task.DTOS.Order;

namespace SoftZone_task.DTOS.Customer
{
    public record CustomerCreateDTO
    {
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

    }
}
