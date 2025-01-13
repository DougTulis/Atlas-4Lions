using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Validacoes;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Threading;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class Pessoa : ModeloAbstrato, IContrato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Contato { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Cpf { get; set; }
        public string? Cnpj { get; set; }
        public string? NumeroCnh { get; set; }
        public DateTime? VencimentoCnh { get; set; }

        public Pessoa() { }

        public Pessoa(string nome, string email, string contato, DateTime dataNascimento, string? cpf = null, string? cnpj = null)
        {
            Nome = nome;
            Email = email;
            Contato = contato;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Cnpj = cnpj;
        }

        public override string? ToString()
        {
            return "Id: " + Id + "\n" +
                   "Nome: " + Nome + "\n" +
                   "Contato: " + Contato + "\n" +
                   "Data Nascimento: " + DataNascimento.ToString("dd/MM/yyyy") + "\n" +
                   "Email: " + Email + "\n" +
                   (Cpf != null ? "CPF: " + Cpf + "\n" : "CNPJ: " + Cnpj + "\n") +
                   "Adicionado em: " + DataCriacao.ToString("dd/MM/yyyy") + "\n";
        }

        public string ExibirDadosBreves()
        {
            return "ID: " + Id + ", Nome: " + Nome + ", " +
                   (Cpf != null ? "CPF: " + Cpf : "CNPJ: " + Cnpj);
        }

        public override bool Validacao()
        {
            var contratos = new ContratoValidacoes<PessoaDTO>()
                .NomeIsOk(Nome, 3, "Nome inválido. Deve conter pelo menos 3 caracteres.", "Nome")
                .EmailIsOk(Email, 2, "Email inválido. Insira um endereço de email válido.", "Email")
                .ContatoIsOk(Contato, 2, "Contato inválido. Informe um número com pelo menos 10 dígitos.", "Contato")
                .DataNascIsOk(DataNascimento, 18, "Data de nascimento inválida, a pessoa tem que ser maior de idade.", "DataNascimento");

            if (Cpf != null)
            {
                contratos.CpfIsOk(Cpf, 11, "CPF inválido. Insira um CPF com 11 dígitos.", "Cpf");
            }
            else if (Cnpj != null)
            {
               // validacao do cnpj
            }

            if (!contratos.IsValid())
            {
                foreach (var notificacao in contratos.Notificacoes)
                {
                    Console.WriteLine($"Erro em {notificacao.NomePropriedade}: {notificacao.Mensagem}");
                    Thread.Sleep(3000);
                }
                return false;
            }
            return true;
        }

        public bool ValidacaoCnh()
        {
            var contratos = new ContratoValidacoes<PessoaDTO>()
                .CnhIsOk(NumeroCnh, 11, "Número de CNH inválido.", "NumeroCnh")
                .VencimentoIsOk(VencimentoCnh, "Vencimento da CNH inválido.", "VencimentoCnh");

            if (!contratos.IsValid())
            {
                foreach (var notificacao in contratos.Notificacoes)
                {
                    Console.WriteLine($"Erro em {notificacao.NomePropriedade}: {notificacao.Mensagem}");
                    Thread.Sleep(3000);
                }
                return false;
            }
            return true;
        }
    }
}
