using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Infraestrutura.Dominio.Entidades;
using Api.Model.Pessoa;

namespace Api.Servico.ConverterPara;

public static class PessoaDominioParaModel
{
    public static PessoaModel Convert(this PessoaDominio pessoaDominio)
    {
        return new PessoaModel
        {
            IdPessoa = pessoaDominio.IdPessoa,
            Nome = pessoaDominio.Nome,
            Cpf = pessoaDominio.Cpf,
            DataNascimento = pessoaDominio.DataNascimento,
            Sexo = pessoaDominio.Sexo,
            Email = pessoaDominio.Email,
            Naturalidade = pessoaDominio.Naturalidade,
            Nacionalidade = pessoaDominio.Nacionalidade,
        };
    }
}
