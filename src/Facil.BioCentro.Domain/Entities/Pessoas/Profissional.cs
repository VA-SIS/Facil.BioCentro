using System;
using JetBrains.Annotations;

namespace Facil.BioCentro.Entities.Pessoas;

public class Profissional : Pessoa
{
    public Profissional(string nome, string email, string profissao) : base(nome, email)
    {
        Nome = nome;
        Email = email;
        Profissao = profissao;
    }

    internal Profissional(Guid id, [NotNull] string nome, [NotNull] string email, string profissao) : base(id, nome, email)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Profissao = profissao;


    }

    //public required string Profissao { get; set; } = string.Empty;

}
