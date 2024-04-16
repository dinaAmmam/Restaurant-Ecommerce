using Microsoft.EntityFrameworkCore;
using SoftZone_task.Data;
using SoftZone_task.Models;
using SoftZone_task.Repositories.Generic_Repository;

namespace SoftZone_task.Repositories.MenuRepository
{
    public class MenuRepository:GenericRepository<Menu>, IMenuRepository
    {
        private readonly SoftZoneDBContext _context;
        public MenuRepository(SoftZoneDBContext context) : base(context)
        {
            _context = context;
        }

        public Menu GetMenuById(int id)
        {
            return _context.Menu
                           .Include(p => p.Items)
                           .FirstOrDefault(p => p.MenuId == id);
        }

    }
}
