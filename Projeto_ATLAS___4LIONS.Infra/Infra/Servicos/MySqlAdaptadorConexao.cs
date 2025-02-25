using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.Interface_Adapter;

namespace Projeto_ATLAS___4LIONS.Infra.Servicos
{
    public class MySqlAdaptadorConexao : IMySqlAdaptadorConexao
    {
        string conexaoSql = "Server=localhost;Port=3306;Database=Atlas;Uid=root;Pwd=nova_senha;";

        public MySqlConnection ObterConexao()
        {
            return new MySqlConnection(conexaoSql);
        }
    }
}
