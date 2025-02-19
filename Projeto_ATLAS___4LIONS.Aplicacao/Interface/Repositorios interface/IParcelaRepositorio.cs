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
    public interface IParcelaRepositorio
    {
        void Adicionar(ParcelaDTO parcelaDto);
        void AdicionarVarias(IEnumerable<ParcelaDTO> parcelasDto);
        IEnumerable<ParcelaDTO> ListarPorPendencia(int pendenciaId);
        void AtualizarPagamentoParcela(int idPendenciaFinanceira, int sequencia, decimal valorPago, DateTime dataPagamento, EEspecie especiePagamento);

        public ParcelaDTO? RecuperarPorId(int id);
    }
}
