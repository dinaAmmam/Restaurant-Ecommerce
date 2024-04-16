using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoftZone_task.DTOS.Restaurant;
using SoftZone_task.Repositories.RestaurantRepository;

namespace SoftZone_task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantRepository restaurantRepo;
        private readonly IMapper mapper;

        public RestaurantController(IRestaurantRepository _restaurantRepository , IMapper _mapper)
        {
            restaurantRepo = _restaurantRepository;
            mapper = _mapper;  
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RestaurantReadDto>>> GetAll()
        {
            List<RestaurantReadDto> restaurants = new List<RestaurantReadDto>();
            foreach (var item in restaurantRepo.GetAllRestaurants())
            {
                RestaurantReadDto r = mapper.Map<RestaurantReadDto>(item);
                restaurants.Add(r);
            }
            return Ok(restaurants);
        }
    }
}
