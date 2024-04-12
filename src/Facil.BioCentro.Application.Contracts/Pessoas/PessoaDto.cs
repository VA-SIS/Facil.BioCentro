using System;
using Volo.Abp.Application.Dtos;

namespace Facil.BioCentro.Pessoas;

public class PessoaDto : AuditedEntityDto<Guid>
{
    public int Codigo { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
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

}
