namespace ProjetoAula02.Entities;

/// <summary>
/// Classe de Entidade para representar uma pessoa
/// </summary>
public abstract class Pessoa
{

    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string DataNascimento { get; set; }

}
