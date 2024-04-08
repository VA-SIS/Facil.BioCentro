using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Facil.BioCentro.Entities.Pessoas
{
    public abstract class Pessoa : AuditedAggregateRoot<Guid>
    {
        public string Nome { get; set; } 
        public string Email { get; set; }

       
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
