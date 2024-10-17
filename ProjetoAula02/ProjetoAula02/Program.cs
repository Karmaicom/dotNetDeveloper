using ProjetoAula02.Entities;
using ProjetoAula02.Repositories;
using System.Configuration;
using System.Text.Json;

namespace ProjetoAula02;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            var setor = new Setor();
            setor.Id = Guid.NewGuid();
            setor.Nome = "Tecnologia";

            var funcao = new Funcao();
            funcao.Id = Guid.NewGuid();
            funcao.Descricao = ".NET Developer";

            var funcionario = new Funcionario();
            funcionario.Id = Guid.NewGuid();
            funcionario.Nome = "Karmaicom Rocha";
            funcionario.Cpf = "123.456.789-00";
            funcionario.DataNascimento = new DateTime(1983, 6, 27);
            funcionario.DataAdmissao = new DateTime(2024, 9, 30);
            funcionario.Matricula = "12";
            funcionario.Setor = setor;
            funcionario.Funcao = funcao;

            var repository = new FuncionarioRepository();
            repository.JsonPrinter(repository.JsonExport(funcionario));   
            repository.XmlExport(funcionario);

            Console.WriteLine(funcionario.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
