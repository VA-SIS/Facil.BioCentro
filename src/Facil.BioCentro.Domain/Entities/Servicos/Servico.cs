using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Facil.BioCentro.Entities.Servicos;

public class Servico : AuditedAggregateRoot<Guid>
{

    public string Descricao { get; set; } = string.Empty;

    public Servico(string descricao)
    {
        Descricao = descricao;
    }
}
