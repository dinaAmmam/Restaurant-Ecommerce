using Microsoft.EntityFrameworkCore;
using SoftZone_task.Data;
using SoftZone_task.Models;
using SoftZone_task.Repositories.Generic_Repository;

namespace SoftZone_task.Repositories.ItemRepository
{
    public class ItemRepository:GenericRepository<Item>, IItemRepository
    {
        private readonly SoftZoneDBContext _context;
        public ItemRepository(SoftZoneDBContext context) : base(context)
        {
            _context = context;
        }
        public List<Item> GetAllItems()
        {
            return _context.Items.Include(a => a.Restaurant).ToList();
        }

        public Item GetItemtById(int id)
        {
            return _context.Items
                           .Include(p => p.Restaurant)
                           .FirstOrDefault(p => p.ItemId == id);
        }
    }
}
