using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _42finance.Domain.Entities.Email
{
    public class EnvioEmail
    {		
		public string De { get; set; }

		public string Para { get; set; }

		public string Copia { get; set; }

		public string CopiaOculta { get; set; }

		public DateTime DtInclusao { get; set; }		
		public string Assunto { get; set; }

		public string Texto { get; set; }

		public bool Enviado { get; set; }

		public DateTime? DataEnvio { get; set; }
		
		public string Erro { get; set; }
		
		public string ReplyTo { get; set; }
	}
}
