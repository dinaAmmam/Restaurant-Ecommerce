using SoftZone_task.Repositories.Generic_Repository;
using SoftZone_task.Models;
using SoftZone_task.Data;
using Microsoft.EntityFrameworkCore;

namespace SoftZone_task.Repositories.RestaurantRepository;

    public class RestaurantRepository:GenericRepository<Restaurant>, IRestaurantRepository
    {
        private readonly SoftZoneDBContext _context;
        public RestaurantRepository(SoftZoneDBContext context):base(context) 
        {
            _context=context;
        
        }
    public List<Restaurant> GetAllRestaurants()
    {
        return _context.Restaurants.Include(a => a.Items).ToList();
    }

    public Restaurant GetRestaurantById(int id)
    {
        return _context.Restaurants
                       .Include(p => p.Items)
                       .FirstOrDefault(p => p.RestaurantId == id);
    }



}

