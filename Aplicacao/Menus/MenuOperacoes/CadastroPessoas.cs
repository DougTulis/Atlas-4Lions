using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;

public static class CadastroPessoas
{
    public static void Cadastrar()
    {
        Console.Clear();
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Contato (Máximo 10 dígitos): ");
        string contato = Console.ReadLine();
        Console.Write("Data de nascimento (dd/MM/yyyy): ");
        DateTime nascimento = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("\nInforme o tipo de pessoa:");
        Console.WriteLine("1. Pessoa Física (CPF)");
        Console.WriteLine("2. Pessoa Jurídica (CNPJ)");
        Console.Write("Opção: ");
        int tipoPessoa = int.Parse(Console.ReadLine());

        string? cpf = null, cnpj = null;
        if (tipoPessoa == 1)
        {
            Console.Write("CPF (Máximo 11 dígitos): ");
            cpf = Console.ReadLine();
        }
        else if (tipoPessoa == 2)
        {
            Console.Write("CNPJ (Máximo 14 dígitos): ");
            cnpj = Console.ReadLine();
        }

        var pessoa = new PessoaDTO(nome, email, contato, nascimento)
        {
            Cpf = cpf,
            Cnpj = cnpj,
            DataCriacao = DateTime.Now
        };

        var pessoaRepositorio = new PessoaRepositorio();
        var UseCase = new CadastrarPessoaUseCase(pessoaRepositorio);
        UseCase.Executar(pessoa);

        Thread.Sleep(2500);
        Console.Clear();
        MenuInicial.Exibir();
    }
}
