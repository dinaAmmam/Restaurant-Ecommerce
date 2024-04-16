using SoftZone_task.Models;
using SoftZone_task.Repositories.Generic_Repository;

namespace SoftZone_task.Repositories.MenuRepository
{
    public interface IMenuRepository:IGenericRepository<Menu>
    {
        public Menu GetMenuById(int id);

    }
}
