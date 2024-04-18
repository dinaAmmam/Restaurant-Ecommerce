using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoftZone_task.DTOS.Customer;
using SoftZone_task.DTOS.Order;
using SoftZone_task.Models;
using SoftZone_task.Repositories.CustomerRepository;
using SoftZone_task.Repositories.OrderRepository;

namespace SoftZone_task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository orderRepo;
        private readonly IMapper mapper;
        public OrderController(IOrderRepository _orderRepository , IMapper _mapper)
        {
            orderRepo = _orderRepository;
            mapper = _mapper;
            
        }

        [HttpGet("{id}")]
        public ActionResult<OrderReadDTO> GetById(int id)
        {
            Order order = orderRepo.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<OrderReadDTO>(order));
        }

        [HttpPost]
        public async Task<ActionResult> Add(OrderCreateDTO o)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var order = mapper.Map<Order>(o);
                    orderRepo.Create(order);
                    orderRepo.SaveChanges();
                    return CreatedAtAction("GetById", new { id = order.OrderId }, o);

                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest(ModelState);

        }
    }
}
