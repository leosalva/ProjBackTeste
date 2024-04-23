using Microsoft.Extensions.DependencyInjection;
using ProjBackTeste.Application.Interface;
using ProjBackTeste.Application.Service;

namespace ProjBackTeste.IoC
{
    public class DependencyInjection
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Services
            services.AddScoped<IUserService, UserService>();
        }
    }
}
