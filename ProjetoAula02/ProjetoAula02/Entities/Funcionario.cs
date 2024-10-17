using System.Security.Principal;

namespace ProjetoAula02.Entities;

public class Funcionario : Pessoa
{
    public Funcionario(string cpf, string matricula, DateTime dataAdmissao, Setor setor, Funcao funcao)
    {
        Cpf = cpf;
        Matricula = matricula;
        DataAdmissao = dataAdmissao;
        Setor = setor;
        Funcao = funcao;
    }

    public Funcionario() { }


    public string Cpf { get; set; }
    public string Matricula { get; set; }
    public DateTime DataAdmissao { get; set; }
    public Setor Setor { get; set; }
    public Funcao Funcao { get; set; }

    public override string ToString()
    {
        return $"Id.........................: {Id}\n" +
               $"Nome.......................: {Nome}\n" +
               $"Cpf........................: {Cpf}\n" +
               $"Matricula..................: {Matricula}\n" +
               $"Data de Admissão...........: {DataAdmissao}\n" +
               "Setor\n" +
               $"  Id.......................: {Setor.Id}\n" +
               $"  Nome.....................: {Setor.Nome}\n" +
               "Função\n" +
               $"  Id.......................: {Funcao.Id}\n" +
               $"  Descrição................: {Funcao.Descricao}\n";
    }

}
