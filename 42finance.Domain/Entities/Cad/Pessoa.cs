using System;

namespace _42finance.Domain.Entities
{
    public class Pessoa
    {
        public string DocumentoFederal { get; set; }
        public string Nome { get; set; }                            
        public DateTime? DtCadastro { get; set; }                        
        public string Apelido { get; set; }                                
        public DateTime? DtNascimento { get; set; }
        public string Sexo { get; set; }                        
        public string EstadoCivil { get; set; }                                                        
        public string Email { get; set; }
        public string TelefoneCelular { get; set; }        
    }
}
