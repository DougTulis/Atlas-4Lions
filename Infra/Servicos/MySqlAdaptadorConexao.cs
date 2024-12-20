using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
