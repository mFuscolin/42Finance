using _42finance.Application.Services.Email;
using _42finance.Application.Services.Mock;
using _42finance.Data.Context.Dapper;
using _42finance.Domain.Base.Intefaces.Data;
using _42finance.Domain.Entities.Email;
using _42finance.Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace _42finance.CrossCutting.DI
{
    public static class ApiDiConfig
    {
        public static void AddDependencyInjection(this IServiceCollection services, bool isMock = false)
        {
            ConfigureServices(services, isMock);
        }

        private static void ConfigureServices(IServiceCollection services, bool isMock)
        {
            if (isMock)
            {
                services.AddTransient<IEnvioEmailService, EnvioEmailServiceMock>();
            }
            else
            {
                services.AddTransient<IEnvioEmailService, EnvioEmailService>();
                services.AddTransient<DapperDbService>();
                services.AddTransient<IDbService, DapperDbServiceBase>();
            }         
        }
    }
}
