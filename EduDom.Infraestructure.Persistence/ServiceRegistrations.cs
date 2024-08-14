using EduDom.Core.Aplication.Interface.Repositories;
using EduDom.Infraestructure.Persistence.Context;
using EduDom.Infraestructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace EduDom.Infraestructure.Persistence
{
    public static class ServiceRegistrations
    {
        public static void AddInfrastructurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(op => op.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), m =>
            m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));


            #region Repositories
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            #endregion

        }
    }
}
