using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace _42finance.CrossCutting.Mapping
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg => 
            {
                cfg.AddProfile<ViewModelToDomainMappingProfile>();
                cfg.AddProfile<DomainToViewModelMappingProfile>();
            });
        }
    }
}
