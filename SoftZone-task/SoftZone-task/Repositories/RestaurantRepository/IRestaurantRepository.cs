using SoftZone_task.Repositories.Generic_Repository;
using SoftZone_task.Models;

namespace SoftZone_task.Repositories.RestaurantRepository
{
    public interface IRestaurantRepository:IGenericRepository<Restaurant>
    {
        public List<Restaurant> GetAllRestaurants();
    }
}
