using _42finance.Domain.Entities.Email;

namespace _42finance.Domain.Interfaces.Services
{
    public interface IEnvioEmailService
    {

        public void Enviar(EnvioEmail envioEmail);
    }
}
