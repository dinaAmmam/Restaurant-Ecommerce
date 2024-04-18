using Microsoft.EntityFrameworkCore;
using SoftZone_task.Data;
using SoftZone_task.Models;
using SoftZone_task.Repositories.Generic_Repository;

namespace SoftZone_task.Repositories.OrderRepository
{
    public class OrderRepository:GenericRepository<Order>, IOrderRepository
    {
        private readonly SoftZoneDBContext _context;
        public OrderRepository(SoftZoneDBContext context) : base(context)
        {
            _context = context;
        }

        public Order GetOrderById(int id)
        {
            return _context.Orders
                           .Include(p => p.Items)
                           .Include(p => p.Customer)
                           .FirstOrDefault(p => p.OrderId == id);
        }
        public void Create(Order order)
        {
            _context.Orders.Add(order);
            SaveChanges();
        }
    }
}
