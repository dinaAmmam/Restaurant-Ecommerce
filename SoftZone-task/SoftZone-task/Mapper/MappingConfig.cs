using AutoMapper;
using SoftZone_task.Data;
using SoftZone_task.DTOS.Customer;
using SoftZone_task.DTOS.Item;
using SoftZone_task.DTOS.Order;
using SoftZone_task.DTOS.Restaurant;
using SoftZone_task.Models;

namespace SoftZone_task.Mapper
{
    public class MappingConfig:Profile
    {
        public MappingConfig()
        {
            CreateMap<Restaurant, RestaurantReadDto>().ReverseMap();
            CreateMap<Item , ItemChildReadDTO>().ReverseMap();
            CreateMap<Customer , CustomerCreateDTO>().ReverseMap();
            CreateMap<Customer , CustomerReadDTO>().ReverseMap();
            CreateMap<Order , OrderReadDTO>().ReverseMap();
            CreateMap<Customer, CustomerChlidReadDto>().ReverseMap();
            CreateMap<Order,OrderCreateDTO>().ReverseMap();
            CreateMap<Customer, CustomerCreateDTO>().ReverseMap();
            CreateMap<Item , ItemsChlidCreateDto>().ReverseMap();
            
        }
        private SoftZoneDBContext dbContext;
        public MappingConfig(SoftZoneDBContext _dbcontext)
        {
            dbContext = _dbcontext;
        }
    }
}
