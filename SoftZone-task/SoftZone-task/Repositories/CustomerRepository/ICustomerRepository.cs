using SoftZone_task.Models;
using SoftZone_task.Repositories.Generic_Repository;

namespace SoftZone_task.Repositories.CustomerRepository
{
    public interface ICustomerRepository:IGenericRepository<Customer>
    {
        public Customer GetCustomerById(int id);

        public void Create(Customer customer);

    }
}
