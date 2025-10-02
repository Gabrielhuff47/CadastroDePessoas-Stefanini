namespace Api.Infraestrutura.Dominio.Entidades;

public class PessoaDominio
{
    public int IdPessoa { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public DateTime DataNascimento { get; set; }
    public string? Sexo { get; set; }
    public string? Email { get; set; }
    public string? Naturalidade { get; set; }
    public string? Nacionalidade { get; set; }
    public string UsuarioAtualizacao { get; set; }
    public DateTime DataAtualizacao { get; set; }
}
