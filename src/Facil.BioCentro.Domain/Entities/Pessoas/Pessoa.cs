using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Facil.BioCentro.Entities.Pessoas
{
    public abstract class Pessoa : AuditedAggregateRoot<Guid>
    {
        public int Codigo { get; set; }
        public string Nome { get; set; } 
        public string Email { get; set; }
        public string Endereco { get; set; } = string.Empty;
        public string Fone { get; set; } = string.Empty;
        public string Profissao { get; set; } = string.Empty;
        public string FoneTrabalho { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public string Municipio { get; set; } = string.Empty;
        public string Uf { get; set; } = string.Empty;
        public string Filiacao { get; set; } = string.Empty;
        public string EnderecoFiliacao { get; set; } = string.Empty;
        public DateTime? DataNascimento { get; set; } 

        public string ConselhoClasse { get; set; } = string.Empty;


        protected Pessoa(Guid id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }

        protected Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
