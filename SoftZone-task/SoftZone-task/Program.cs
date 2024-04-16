
using Microsoft.EntityFrameworkCore;
using SoftZone_task.Data;
using SoftZone_task.Mapper;
using SoftZone_task.Repositories.CustomerRepository;
using SoftZone_task.Repositories.MenuRepository;
using SoftZone_task.Repositories.OrderRepository;
using SoftZone_task.Repositories.RestaurantRepository;

namespace SoftZone_task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<SoftZoneDBContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("SoftZonecon")));

            builder.Services.AddAutoMapper(typeof(MappingConfig));
            builder.Services.AddScoped<IRestaurantRepository, RestaurantRepository>();
            builder.Services.AddScoped<IMenuRepository, MenuRepository>();
            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
