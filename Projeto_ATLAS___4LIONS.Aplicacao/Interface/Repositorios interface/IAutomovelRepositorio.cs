using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface
{
    public interface IAutomovelRepositorio
    {

        public IEnumerable<AutomovelDTO> ListarTodos();
        public IEnumerable<AutomovelDTO> PopularLista(MySqlDataReader dataReader);
        public void Adicionar(Automovel objeto);
        public void Deletar(Guid id);
        public AutomovelDTO? RecuperarPorId(Guid id);
        public void AtualizarStatus(Guid automovelId, EStatusVeiculo novoStatus);
        public IEnumerable<AutomovelDTO> ListarStatusGaragem();
    }

}
