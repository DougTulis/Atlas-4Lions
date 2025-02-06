namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class PessoaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Contato { get; set; }
        public string? Cpf { get; set; }
        public string? Cnpj { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? NumeroCnh { get; set; }
        public DateTime? VencimentoCnh { get; set; }
        public DateTime DataCriacao { get; set; }

        public PessoaDTO(string nome, string email, string contato, string? cpf, string? cnpj)
        {
            Nome = nome;
            Email = email;
            Contato = contato;
            Cpf = cpf;
            Cnpj = cnpj;
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
    }
}
