using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Validacoes;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class PessoaCnh : ModeloAbstrato2, IContrato
    {
        public Guid Id { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Contato { get; private set; }
        public ETipoPessoa TipoPessoa { get; private set; }
        public string NumeroDocumento { get; private set; }
        public DateTime DataRegistro { get; private set; }
        public string? NumeroCnh { get; private set; }
        public DateTime? VencimentoCnh { get; private set; }

        public PessoaCnh(Guid id, DateTime dataCriacao, string nome, string email, string contato, ETipoPessoa tipoPessoa, string numeroDocumento, DateTime dataRegistro, string? numeroCnh, DateTime? vencimentoCnh) : base(id, dataCriacao)
        {
            Id = id;
            DataCriacao = dataCriacao;
            Nome = nome;
            Email = email;
            Contato = contato;
            TipoPessoa = tipoPessoa;
            NumeroDocumento = numeroDocumento;
            DataRegistro = dataRegistro;
            NumeroCnh = numeroCnh;
            VencimentoCnh = vencimentoCnh;
        }

        public static PessoaCnh Create(Guid id, DateTime dataCriacao, string nome, string email, string contato, ETipoPessoa tipoPessoa, string numeroDocumento, DateTime dataRegistro, string? numeroCnh, DateTime? vencimentoCnh)
        {
            return new PessoaCnh(id,dataCriacao,nome,email,contato,tipoPessoa,numeroDocumento,dataRegistro,numeroCnh,vencimentoCnh);
        }

        public override bool Validacao(out string erros)
        {
            {
                erros = "";
                var contratos = new ContratoValidacoes<PessoaCnh>()
                    .CnhIsOk(NumeroCnh, 11, "Número da CNH inválido.", "NumeroCnh")
                    .VencimentoIsOk(VencimentoCnh, "Vencimento da CNH inválido.", "VencimentoCnh");

                if (!contratos.IsValid())
                {
                    erros = contratos.CapturadorErros();
                    return false;
                }
                return true;
            }
        }

        public bool ValidacaoExclusao(bool temVinculacao, out string erros)
        {
            erros = "";
            var contratos = new ContratoValidacoes<PessoaCnh>()
            .TemVinculacao(temVinculacao, "A pessoa que você deseja excluir está vinculada á uma locação em andamento","");

            if (!contratos.IsValid())
            {
                erros = contratos.CapturadorErros();
                return true;
            }
            return false;
        }
    }
}
