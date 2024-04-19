using SoftZone_task.Models;
using SoftZone_task.Repositories.Generic_Repository;

namespace SoftZone_task.Repositories.ItemRepository
{
    public interface IItemRepository:IGenericRepository<Item>
    {
        public List<Item> GetAllItems();

        public Item GetItemtById(int id);
    }
}
