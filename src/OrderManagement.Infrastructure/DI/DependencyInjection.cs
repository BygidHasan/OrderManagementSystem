using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using OrderManagement.Infrastructure.Data;

namespace OrderManagement.Infrastructure.DI
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
      services.AddDbContext<AppDbContext>(options =>
          options.UseSqlite(connectionString));
      
      return services;
    }
  }
}