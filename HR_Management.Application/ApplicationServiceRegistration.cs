using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace HR_Management.Application;

public static class ApplicationServiceRegistration
{
    public static void ConfigureApplicationService(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}