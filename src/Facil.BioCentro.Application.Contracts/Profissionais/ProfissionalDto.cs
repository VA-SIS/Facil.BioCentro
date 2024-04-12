using Facil.BioCentro.Enums;
using System;

namespace Facil.BioCentro.Profissionais;

public class ProfissionalDto
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Cpf_Cnpj { get; set; }

    public string Profissao { get; set; }

    public PessoaType TipoPessoa { get; set; }
}
