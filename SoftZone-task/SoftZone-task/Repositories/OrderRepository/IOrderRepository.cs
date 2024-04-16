using SoftZone_task.Models;
using SoftZone_task.Repositories.Generic_Repository;

namespace SoftZone_task.Repositories.OrderRepository
{
    public interface IOrderRepository:IGenericRepository<Order>
    {
        public Order GetOrderById(int id);

        public void Create(Order order);
    }
}
