using Facil.BioCentro.Enums;
using System;
using Volo.Abp.Application.Dtos;

namespace Facil.BioCentro.Clientes;

public class ClienteDto : AuditedEntityDto<Guid>
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Cpf_Cnpj { get; set; }
    public PessoaType TipoPessoa { get; set; }
}
