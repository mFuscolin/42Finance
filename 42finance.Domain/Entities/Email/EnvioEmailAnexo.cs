using System;

namespace _42finance.Domain.Entities.Email
{
	public class EnvioEmailAnexo 
	{
		public Guid CodigoEnvioEmail { get; set; }

		public byte[] Arquivo { get; set; }
		
		public string NomeArquivo { get; set; }

		public string Extensao { get; set; }
	}
}