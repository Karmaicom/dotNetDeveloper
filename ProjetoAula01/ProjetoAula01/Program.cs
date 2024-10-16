using ProjetoAula01.Entities;
using ProjetoAula01.Helpers;
using ProjetoAula01.Repositories;

namespace ProjetoAula01;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Aula 01 - C# WebDeveloper");

        var cliente = new Cliente();

        cliente.Id = Guid.NewGuid();
        cliente.Nome = ClienteHelper.LerNome();
        cliente.Email = ClienteHelper.LerEmail();
        cliente.Cpf = ClienteHelper.LerCpf();
        cliente.DataNascimento = ClienteHelper.LerDataNascimento();

        Console.WriteLine("\nDados do Cliente\n");
        Console.WriteLine($"Id................: {cliente.Id}");
        Console.WriteLine($"Nome..............: {cliente.Nome}");
        Console.WriteLine($"Email.............: {cliente.Email}");
        Console.WriteLine($"CPF...............: {cliente.Cpf}");
        Console.WriteLine($"Data Nascimento...: {cliente.DataNascimento.ToString("dd/MM/yyyy")}");

        var repo = new ClienteRepository();
        repo.ExportarDados( cliente );

    }
}
