using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoftZone_task.DTOS.Customer;
using SoftZone_task.Models;
using SoftZone_task.Repositories.CustomerRepository;

namespace SoftZone_task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository customerRepo;
        private readonly IMapper mapper;
        public CustomerController(ICustomerRepository _customerRepository, IMapper _mapper)
        {
            customerRepo = _customerRepository;
            mapper = _mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<CustomerReadDTO> GetById(int id)
        {
            Customer customer = customerRepo.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<CustomerReadDTO>(customer));
        }

        [HttpPost]
        public async Task<ActionResult> Add(CustomerCreateDTO c)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var customer = mapper.Map<Customer>(c);
                    customerRepo.Create(customer);
                    customerRepo.SaveChanges();
                    return CreatedAtAction("GetById", new { id = customer.CustomerId }, c);

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
