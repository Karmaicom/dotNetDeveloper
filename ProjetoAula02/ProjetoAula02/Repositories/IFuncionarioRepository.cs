using ProjetoAula02.Entities;

namespace ProjetoAula02.Repositories;

public interface IFuncionarioRepository
{
    public string JsonExport(Funcionario funcionario);

    public void XmlExport(Funcionario funcionario);

    public void JsonPrinter(string json);

}
