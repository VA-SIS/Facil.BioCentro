using Facil.BioCentro.Enums;
using JetBrains.Annotations;
using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Facil.BioCentro.Entities.Pessoas;

public class Cliente : Pessoa
{
    public string Cpf_Cnpj { get; set; }
    public PessoaType TipoPessoa { get; set; }

    public Cliente([NotNull] string nome, [NotNull] string email) : base(nome, email)
    {
        Id = Guid.Empty;
        Nome = nome;
        Email = email;


    }

    public Cliente(Guid id, [NotNull] string nome, [NotNull] string email ) : base(id, nome, email)
    {
        Id = id;
        Nome = nome;
        Email = email;

        
    }

   
}
