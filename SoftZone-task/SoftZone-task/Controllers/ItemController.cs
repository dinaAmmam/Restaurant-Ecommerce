using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoftZone_task.DTOS.Item;
using SoftZone_task.DTOS.Restaurant;
using SoftZone_task.Models;
using SoftZone_task.Repositories.ItemRepository;
using SoftZone_task.Repositories.RestaurantRepository;

namespace SoftZone_task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository itemRepository;
        private readonly IMapper mapper;
        public ItemController(IItemRepository _itemRepository , IMapper _mapper)
        {
            itemRepository = _itemRepository;
            mapper = _mapper;
            
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemReadDto>>> GetAll()
        {
            List<ItemReadDto> items = new List<ItemReadDto>();
            foreach (var item in itemRepository.GetAllItems())
            {
                ItemReadDto i = mapper.Map<ItemReadDto>(item);
                items.Add(i);
            }
            return Ok(items);
        }

        [HttpGet("{id}")]
        public ActionResult<ItemReadDto> GetById(int id)
        {
            Item item = itemRepository.GetItemtById(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<ItemReadDto>(item));
        }
    }
}
