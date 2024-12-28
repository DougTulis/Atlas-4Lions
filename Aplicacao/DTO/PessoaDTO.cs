using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Validacoes;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class PessoaDTO
    {

        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Contato { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public CnhValida CnhValida { get; set; }


        public PessoaDTO(string nome, string email, string contato, DateTime dataNascimento, string cpf)
        {
            Nome = nome;
            Email = email;
            Contato = contato;
            DataNascimento = dataNascimento;
            Cpf = cpf;
        }
        public PessoaDTO(PessoaDTO pessoa, CnhValidaDTO cnhValida) // sobrecarga para definir a cnh em pessoa
        {
            this.Nome = pessoa.Nome;
            this.Email = pessoa.Email;
            this.Contato = pessoa.Contato;
            this.DataNascimento = pessoa.DataNascimento;
            this.Cpf = pessoa.Cpf;
            this.CnhValida = pessoa.CnhValida;
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

    }
}
