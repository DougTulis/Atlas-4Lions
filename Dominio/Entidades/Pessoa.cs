using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Validacoes;
using System;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class Pessoa : ModeloAbstrato, IContrato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Contato { get; set; }
        public string? Cpf { get; set; }
        public string? Cnpj { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? NumeroCnh { get; set; }
        public DateTime? VencimentoCnh { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, string email, string contato, string? cpf, string? cnpj, DateTime? dataNascimento = null)
        {
            Nome = nome;
            Email = email;
            Contato = contato;
            Cpf = cpf;
            Cnpj = cnpj;
            DataNascimento = dataNascimento;
        }

        public override string ToString()
        {
            return $"Id: {Id}\n" +
                   $"Nome: {Nome}\n" +
                   $"Contato: {Contato}\n" +
                   $"Email: {Email}\n" +
                   (Cpf != null ? $"CPF: {Cpf}\n" : "") +
                   (Cnpj != null ? $"CNPJ: {Cnpj}\n" : "") +
                   (DataNascimento != null ? $"Data de Nascimento: {DataNascimento.Value:dd/MM/yyyy}\n" : "") +
                   (NumeroCnh != null ? $"CNH: {NumeroCnh}, Vencimento: {VencimentoCnh?.ToString("dd/MM/yyyy")}\n" : "") +
                   $"Adicionado em: {DataCriacao:dd/MM/yyyy}\n";
        }

        public string ExibirDadosBreves()
        {
            return $"ID: {Id}, Nome: {Nome}, " +
                   (Cpf != null ? $"CPF: {Cpf}" : $"CNPJ: {Cnpj}");
        }

        public override bool Validacao()
        {
            var contratos = new ContratoValidacoes<PessoaDTO>()
                .NomeIsOk(Nome, 3, "Nome inválido. Deve conter pelo menos 3 caracteres.", "Nome")
                .EmailIsOk(Email, 2, "Email inválido. Insira um endereço de email válido.", "Email")
                .ContatoIsOk(Contato, 10, "Contato inválido. Informe um número com pelo menos 10 dígitos.", "Contato");

            if (Cpf != null)
            {
                contratos.CpfIsOk(Cpf, 11, "CPF inválido. Insira um CPF com 11 dígitos.", "Cpf");
            }

            if (Cnpj != null)
            {
               contratos.CnpjIsOk(Cnpj, 14, "CNPJ inválido. Insira um CNPJ com 14 dígitos.", "Cnpj");
            }

            if (DataNascimento != null)
            {
                contratos.DataNascIsOk(DataNascimento.Value, 18, "Data de nascimento inválida. A pessoa precisa ser maior de idade.", "DataNascimento");
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
                .CnhIsOk(NumeroCnh, 11, "Número da CNH inválido.", "NumeroCnh")
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
