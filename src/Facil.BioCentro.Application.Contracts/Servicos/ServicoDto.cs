using System;
using Volo.Abp.Application.Dtos;

namespace Facil.BioCentro.Servicos;

public class ServicoDto : AuditedEntityDto<Guid>
{
    public string Descricao { get; set; } = string.Empty;
}
