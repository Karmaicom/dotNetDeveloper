using ProjetoAula02.Entities;
using System.Text.Json;
using System.Xml.Serialization;

namespace ProjetoAula02.Repositories;

public class FuncionarioRepository : IFuncionarioRepository
{
    public string JsonExport(Funcionario funcionario)
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string funcionarioJson = JsonSerializer.Serialize(funcionario, options);
        return funcionarioJson;
    }

    public void JsonPrinter(string json)
    {
        var streamWriter = new StreamWriter("c:\\temp\\funcionario.json");
        streamWriter.WriteLine(json);
        streamWriter.Close();
    }

    public void XmlExport(Funcionario funcionario)
    {
        var xml = new XmlSerializer(funcionario.GetType());
        var streamWriter = new StreamWriter("c:\\temp\\funcionario.xml");
        xml.Serialize(streamWriter, funcionario);
        streamWriter.Close();
    }
}
