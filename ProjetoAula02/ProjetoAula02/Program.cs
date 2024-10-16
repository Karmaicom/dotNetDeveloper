using System.Configuration;

namespace ProjetoAula02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string version = ConfigurationManager.AppSettings["Version"] ?? "";
                Console.WriteLine(version);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
