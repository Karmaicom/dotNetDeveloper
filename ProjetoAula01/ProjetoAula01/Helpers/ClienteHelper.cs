namespace ProjetoAula01.Helpers;

public abstract class ClienteHelper
{

    public static string LerNome()
    {
        Console.Write("Informe o nome do cliente: ");
        return Console.ReadLine()!;
    }

    public static string LerEmail()
    {
        Console.Write("Informe o e-mail do cliente: ");
        return Console.ReadLine()!;
    }

    public static string LerCpf()
    {
        Console.Write("Informe o cpf do cliente: ");
        return Console.ReadLine()!;
    }

    public static DateTime LerDataNascimento()
    {
        Console.Write("Informe a Data de Nascimento do cliente: ");
        return DateTime.Parse(Console.ReadLine()!);
    }

}