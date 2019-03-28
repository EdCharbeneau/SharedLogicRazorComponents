using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.DataAccess
{
    public static class NorthwindServiceExtension
    {
        public static IServiceCollection UseNorthwindDatabase(this IServiceCollection services, string sqlConnectionString) =>
            services.AddDbContext<NorthwindDBContext>(options => options.UseSqlServer(sqlConnectionString));
    }
}
