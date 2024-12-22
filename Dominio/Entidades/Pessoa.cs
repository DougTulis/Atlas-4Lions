﻿using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Validacoes;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class Pessoa : ModeloAbstrato, IContrato
    { 
        public string Nome { get; set; }
        public string  Email { get; set; }
        public string Contato { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public CnhValida CnhValida { get; set; }
        public ETipoPessoa TipoPessoa { get; set; }


        public Pessoa(string nome, string email, string contato, DateTime dataNascimento, string cpf)
        {
            TipoPessoa = ETipoPessoa.LOCATARIO;
            Nome = nome;
            Email = email;
            Contato = contato;
            DataNascimento = dataNascimento;
            Cpf = cpf;
        }
        public Pessoa(PessoaDTO pessoa, CnhValidaDTO cnhValida) // sobrecarga para definir a cnh em pessoa
        {
            this.Nome = pessoa.Nome;
            this.Email = pessoa.Email;
            this.Contato = pessoa.Contato;
            this.DataNascimento = pessoa.DataNascimento;
            this.Cpf = pessoa.Cpf;
            this.CnhValida = pessoa.CnhValida;
            TipoPessoa = ETipoPessoa.CONDUTOR;
        }
        public override string? ToString()
        {
            return "Id: " + Id + "\n" +
                "Nome: " + Nome + "\n" +
                "Contato: " + Contato + "\n" +
                "Data Nascimento: " + DataNascimento.ToString("dd/MM/yyyy") + "\n" +
                "Email: " +
                "Cpf: " + Cpf + "\n" +
                "Adicionado em: " + DataCriacao + "\n";
        }

        public string ExibirDadosBreves()
        {
            return "ID: " + Id + ", " + Nome + ", " + " CPF: " + Cpf;
        }

        public override bool Validacao()
        {
            var contratos = new ContratoValidacoes<PessoaDTO>()
                .NomeIsOk(this.Nome, 3, "Nome inválido. Deve conter pelo menos 3 caracteres.", "Nome")
                .EmailIsOk(this.Email, 2, "Email inválido. Insira um endereço de email válido.", "Email")
                .ContatoIsOk(this.Contato, 2, "\"Contato inválido. informa um número com pelo menos 10 dígitos.", "Contato")
                .DataNascIsOk(this.DataNascimento, 18, "\"Data de nascimento inválida, a pessoa tem que ser maior de idade", "DataNascimento")
                .CpfIsOk(this.Cpf, 11, "CPF inválido. Insira um CPF com 11 dígitos", "Cpf");

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
