using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Facil.BioCentro.Entities.Pessoas
{
    public abstract class Pessoa : AuditedAggregateRoot<Guid>
    {
        public string Nome { get; set; } 
        public string Email { get; set; }

    }
}
