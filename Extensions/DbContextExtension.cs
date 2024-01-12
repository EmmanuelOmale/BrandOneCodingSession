using BrandOneCodingSession.Infrasatructure;
using Microsoft.EntityFrameworkCore;

namespace BrandOneCodingSession.Extensions
{
    public static class DbContextExtension
    {
        public static void DbContextConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => 
            options.UseSqlServer(configuration.GetConnectionString("SqlServer")));
        }
    }
}
