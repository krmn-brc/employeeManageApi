
using EmployeeManageAp.Web.Repositories.Common;
using EmployeeManageAp.Web.Repositories.Concrete;
using EmployeeManageAp.Web.Repositories.Contracts;
using EmployeeManageAp.Web.Services.Concrete;
using EmployeeManageAp.Web.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManageAp.Web.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
             services.AddDbContext<RepositoryContext>(options => {
                  options.UseSqlite(configuration.GetConnectionString("Sqlite"));
             });
        }

        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }

        public static void ConfigureService(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IDepartmentService, DepartmentManager>();
            services.AddScoped<IEmployeeService, EmployeeManager>();
        }
    }
}