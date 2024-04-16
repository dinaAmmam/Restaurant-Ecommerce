using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoftZone_task.DTOS.Menu;
using SoftZone_task.Models;
using SoftZone_task.Repositories.MenuRepository;
using SoftZone_task.Repositories.RestaurantRepository;

namespace SoftZone_task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuRepository menuRepo;
        private readonly IMapper mapper;
        public MenuController(IMenuRepository _menuRepository , IMapper _mapper)
        {
            menuRepo = _menuRepository;
            mapper= _mapper; 
        }

        [HttpGet("{id}")]
        public ActionResult<MenuChlidReadDto> GetById(int id)
        {
            Menu menu = menuRepo.GetMenuById(id);
            if (menu == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<MenuChlidReadDto>(menu));
        }
    }
}
