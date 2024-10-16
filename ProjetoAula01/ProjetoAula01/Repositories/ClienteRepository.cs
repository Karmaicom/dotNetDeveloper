namespace ProjetoAula01.Repositories;

using ProjetoAula01.Entities;

public class ClienteRepository
{

    public void ExportarDados(Cliente cliente)
    {
        try
        {
            var streamWriter = new StreamWriter(@"c:\\temp\\clientes.txt", true);

            streamWriter.WriteLine($"ID..........................: {cliente.Id}");
            streamWriter.WriteLine($"NOME........................: {cliente.Nome}");
            streamWriter.WriteLine($"EMAIL.......................: {cliente.Email}");
            streamWriter.WriteLine($"CPF.........................: {cliente.Cpf}");
            streamWriter.WriteLine($"DATA DE NASCIMENTO..........: {cliente.DataNascimento}");

            streamWriter.Flush();
            streamWriter.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
        }
        

    }

}
