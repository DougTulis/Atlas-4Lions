using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Validacoes;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades;

public class Pessoa : ModeloAbstrato, IContrato
{
   
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string Contato { get; private set; }
    public ETipoPessoa TipoPessoa { get; private set; }
    public string NumeroDocumento { get; private set; }
    public DateTime DataRegistro { get; private set; }
    public string? NumeroCnh { get; private set; }
    public DateTime? VencimentoCnh { get;  private set; }

    private Pessoa(string nome, string email, string contato, ETipoPessoa tipoPessoa, string numeroDocumento, DateTime dataRegistro)
    {
        Nome = nome;
        Email = email;
        Contato = contato;
        TipoPessoa = tipoPessoa;
        NumeroDocumento = numeroDocumento;
        DataRegistro = dataRegistro;
    }


    //public Pessoa() não devemos ter pois isso não se trata de dominio rico em amenico
    //{
    //}

    //public Pessoa(string nome, string email, string contato, string? cpf, string? cnpj, DateTime? dataNascimento = //null)
    //{
    //    Nome = nome;
    //    Email = email;
    //    Contato = contato;
    //    Cpf = cpf;
    //    Cnpj = cnpj;
    //    DataNascimento = dataNascimento;
    //}

    public static Pessoa Create(string nome, string email, string contato, ETipoPessoa tipoPessoa, string numeroDocumento, DateTime dataRegistro)
    {
        return new Pessoa(nome,email,contato,tipoPessoa,numeroDocumento,dataRegistro);
    }

    public override bool Validacao()
    {
        var contratos = new ContratoValidacoes<Pessoa>()
            .NomeIsOk(Nome, 3, "Nome inválido. Deve conter pelo menos 3 caracteres.", "Nome")
            .EmailIsOk(Email, 2, "Email inválido. Insira um endereço de email válido.", "Email")
            .ContatoIsOk(Contato, 10, "Contato inválido. Informe um número com pelo menos 10 dígitos.", "Contato");

        if (TipoPessoa == ETipoPessoa.FISICA)
        {
            contratos.DataNascimentoIsOk(DataRegistro, 18, "Data de nascimento inválida. Deve ser maior de idade.", "DataNascimento");
        }
        else if (TipoPessoa == ETipoPessoa.JURIDICA)
        {
            contratos.DataRegistroIsOk(DataRegistro, 1, "Data de fundação inválida.", "DataRegistro");
        }

        if (!contratos.IsValid())
        {
            return false;
        }

        return true;
    }


    public bool ValidacaoCnh()
    {
        var contratos = new ContratoValidacoes<Pessoa>()
            .CnhIsOk(NumeroCnh, 11, "Número da CNH inválido.", "NumeroCnh")
            .VencimentoIsOk(VencimentoCnh, "Vencimento da CNH inválido.", "VencimentoCnh");

        if (!contratos.IsValid())
        {
            return false;
        }

        return true;
    }
}
