using SoftZone_task.DTOS.Customer;

namespace SoftZone_task.DTOS.Order
{
    public class OrderReadDTO
    {
        public int OrderId { get; set; }
        public int SubTotal { get; set; }
        public int Total { get; set; }
        public int CustomerId { get; set; }
        public CustomerChlidReadDto customer { get; set; }

    }
}
