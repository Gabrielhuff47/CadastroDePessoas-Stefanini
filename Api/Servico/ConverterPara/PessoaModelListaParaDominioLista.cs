using Api.Infraestrutura.Dominio.Entidades;
using Api.Model.Pessoa;

namespace Api.Servico.ConverterPara;

public static class PessoaModelListaParaDominioLista
{
        public static IEnumerable<PessoaDominio> Convert(this IEnumerable<PessoaModel> pessoas)
    {
        return pessoas.Select(pessoa => pessoa.Convert());
    }
}
