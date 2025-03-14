using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class HistoricoLocacaoDTO
    {
        public Guid Id { get; set; }
        public string NomeLocatario { get; set; }
        public string NomeCondutor { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime Saida { get; set; }
        public DateTime Retorno { get; set; }
        public ETipoLocacao TipoLocacao { get; set; }
        public decimal ValorTotal { get; set; }
        public EStatusLocacao Status { get; set; }

        public HistoricoLocacaoDTO()
        {
        }

        public HistoricoLocacaoDTO(Guid id, string nomeLocatario, string nomeCondutor, DateTime dataCriacao, DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao, decimal valorTotal, EStatusLocacao status)
        {
            Id = id;
            NomeLocatario = nomeLocatario;
            NomeCondutor = nomeCondutor;
            DataCriacao = dataCriacao;
            Saida = saida;
            Retorno = retorno;
            TipoLocacao = tipoLocacao;
            ValorTotal = valorTotal;
            Status = status;
        }
    }

}
