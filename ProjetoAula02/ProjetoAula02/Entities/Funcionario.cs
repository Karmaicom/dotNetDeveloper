using System.Security.Principal;

namespace ProjetoAula02.Entities;

public class Funcionario : Pessoa
{

    public string Cpf { get; set; }
    public string Matricula { get; set; }
    public DateTime DataAdmissao { get; set; }
    public Setor Setor { get; set; }
    public Funcao Funcao { get; set; }

}
