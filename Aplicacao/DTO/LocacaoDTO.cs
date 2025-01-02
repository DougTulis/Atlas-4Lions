using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class LocacaoDTO 
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime Saida { get; set; }
        public DateTime Retorno { get; set; }
        public ETipoLocacao TipoLocacao { get; set; }
        public decimal ValorTotal { get; set; }
        public Pessoa Locatario { get; set; }
        public Pessoa Condutor { get; set; }
        public Automovel Automovel { get; set; }
        public PendenciaFinanceira PendenciaFinanceira { get; set; }
        public EStatusLocacao Status { get; set; }

        public LocacaoDTO(DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao, decimal valorTotal, Pessoa locatario, Pessoa condutor, Automovel automovel, PendenciaFinanceira pendenciaFinanceira)
        {
            Saida = saida;
            Retorno = retorno;
            TipoLocacao = tipoLocacao;
            ValorTotal = valorTotal;
            Locatario = locatario;
            Condutor = condutor;
            Automovel = automovel;
            PendenciaFinanceira = pendenciaFinanceira;
        }
    }
}
