using Microsoft.EntityFrameworkCore;
using SoftZone_task.Data;
using SoftZone_task.Models;
using SoftZone_task.Repositories.Generic_Repository;

namespace SoftZone_task.Repositories.CustomerRepository
{
    public class CustomerRepository:GenericRepository<Customer>, ICustomerRepository
    {
        private readonly SoftZoneDBContext _context;
        public CustomerRepository(SoftZoneDBContext context) : base(context)
        {
            _context = context;

        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customers
                           .Include(p => p.Orders)
                           .FirstOrDefault(p => p.CustomerId == id);
        }
        public void Create(Customer customer)
        {
            _context.Customers.Add(customer);
            SaveChanges();
        }
    }
}
