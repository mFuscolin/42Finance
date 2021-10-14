using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42finance.CrossCutting.DI
{
    public static class ApiDiConfig
    {
        public static void AddDependencyInjection(this IServiceCollection services, bool forWorkers = false, bool ignoreIdentity = false)
        {
            ///ConfigureDomainServices(services, forWorkers);
        }

		private static void ConfigureServices(IServiceCollection services, bool forWorkers)
		{
			if (!forWorkers)
			{
				//services.AddTransient<AutenticacaoSsoService>();
			}

			//services.AddTransient<SafeEfDbService>();
		}
	}
}
