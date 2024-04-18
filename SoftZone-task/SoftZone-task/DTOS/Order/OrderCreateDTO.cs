using SoftZone_task.DTOS.Item;

namespace SoftZone_task.DTOS.Order
{
    public class OrderCreateDTO
    {
        public int CustomerId { get; set; }
        //public ItemsChlidCreateDto items { get; set; }
        public int? SubTotal { get; set; }
        public int? Total { get; set; }
        public List<int> ItemsID { get; set; }


    }
}
