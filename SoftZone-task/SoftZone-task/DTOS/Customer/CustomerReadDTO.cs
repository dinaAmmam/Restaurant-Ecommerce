using SoftZone_task.DTOS.Item;

namespace SoftZone_task.DTOS.Customer
{
    public record CustomerReadDTO
    {
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

    }
}
