using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class PessoaDTO
    {

        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Contato { get; set; }
        public ETipoPessoa TipoPessoa { get; set; }

        public string NumeroDocumento { get;  set; } 
        public DateTime DataRegistro { get; set; }
        public string? NumeroCnh { get; set; }
        public DateTime? VencimentoCnh { get; set; }

        public PessoaDTO()
        {
        }

        public PessoaDTO(Guid id, DateTime dataCriacao, string nome, string email, string contato, ETipoPessoa tipoPessoa, string numeroDocumento, DateTime dataRegistro, string? numeroCnh, DateTime? vencimentoCnh)
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

        public override string? ToString()
        {
            return Nome;
        }
    }
}
