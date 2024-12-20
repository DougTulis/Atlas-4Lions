using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class PessoaDTO : ModeloAbstrato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string  Contato { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }

        public PessoaDTO(string nome, string email, string contato, DateTime dataNascimento, string cpf)
        {
            Nome = nome;
            Email = email;
            Contato = contato;
            DataNascimento = dataNascimento;
            Cpf = cpf;
        }

        public override string? ToString()
        {
            return "Id: " + Nome + "\n" +
                "Nome: " + Nome + "\n" +
                "Contato: " + Contato + "\n" +
                "Data Nascimento: " + DataNascimento.ToString("dd/MM/yyyy") + "\n" +
                "Email: " +
                "Cpf: " + Cpf + "\n";
        }
        
        public string ExibirDadosBreves()
        {
            return "ID: " + Id + ". " + Nome + ", " + " CPF: " + Cpf; 
        }
    }
}
