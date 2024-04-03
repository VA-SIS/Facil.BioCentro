using Facil.BioCentro.Enums;

namespace Facil.BioCentro.Entities.Pessoas;

public class Cliente : Pessoa
{
    public string Cpf_Cnpj { get; set; }
    public PessoaType TipoPessoa { get; set; }

}
