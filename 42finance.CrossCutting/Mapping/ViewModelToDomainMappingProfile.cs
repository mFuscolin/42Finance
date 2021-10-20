using _42finance.Domain.Entities.Email;
using _42finance.Domain.ViewModels.Email;
using AutoMapper;

namespace _42finance.CrossCutting.Mapping
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {            
            CreateMap<EmailViewModel, EnvioEmail>();
        }
    }
}
