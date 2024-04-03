using System.ComponentModel;

namespace Facil.BioCentro.Enums;

public enum PessoaType
{
    [Description("Pessoa Física")]
    Fisica = 0,
    [Description("Pessoa Jurídica")]
    Juridica = 1
}
