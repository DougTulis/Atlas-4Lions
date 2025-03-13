using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface.Interface_Adapter
{
    public interface IMySqlAdaptadorConexao
    {
        public MySqlConnection ObterConexao();
    }
}
