namespace BurgerApp.Helpers
{
    using BurgerApp.DataAccess.DataContext;
    using BurgerApp.DataAccess.Repositories.Implementations;
    using BurgerApp.DataAccess.Repositories.Interfaces;
    using BurgerApp.Domain.Models;
    using BurgerApp.Services.Implementations;
    using BurgerApp.Services.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    public static class DependencyInjectionHelper
    {
        public static void InjectDbContext(this IServiceCollection services)
        {
            services.AddDbContext<BurgerAppDbContext>(options => options.UseSqlServer("Data Source=ALEKSANDAR\\SQLEXPRESS;Database=BurgerAppDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));
        }

        public static void InjectRepositories(this IServiceCollection services)
        {
            services.AddTransient<IRepository<Burger>, BurgerRepository>();
        }

        public static void InjectServices(this IServiceCollection services)
        {
            services.AddTransient<IBurgerService, BurgerService>();
        }
    }
}
