using MySql.Data.MySqlClient;

namespace Projeto_ATLAS___4LIONS.Infra.Servicos
{
    public class MySqlAdaptadorConexao
    {
        string conexaoSql = "Server=localhost;Port=3306;Database=Atlas;Uid=root;Pwd=1234;";

        public MySqlConnection ObterConexao()
        {
            return new MySqlConnection(conexaoSql);
        }
    }
}
