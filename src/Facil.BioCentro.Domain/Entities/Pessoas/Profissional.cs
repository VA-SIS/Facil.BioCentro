using System;
using JetBrains.Annotations;

namespace Facil.BioCentro.Entities.Pessoas;

public class Profissional : Pessoa
{
    

    internal Profissional(Guid id, [NotNull] string nome, [NotNull] string email) : base(id, nome, email)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Profissao = string.Empty;


    }

    public  required  string Profissao { get; set; }

}
