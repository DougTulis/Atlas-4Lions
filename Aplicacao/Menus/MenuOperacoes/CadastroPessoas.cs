﻿using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class CadastroPessoas
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

            Console.Write("Pessoa Física ou Jurídica? (1 - Física, 2 - Jurídica): ");
            int tipoPessoa = int.Parse(Console.ReadLine());

            string? cpf = null;
            string? cnpj = null;
            DateTime? dataNascimento = null;

            if (tipoPessoa == 1) 
            {
                Console.Write("CPF (Máximo 11 dígitos): ");
                cpf = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(cpf))
                {
                    Console.WriteLine("CPF é obrigatório para Pessoa Física.");
                    return;
                }

                Console.Write("Data de Nascimento (dd/MM/yyyy): ");
                dataNascimento = DateTime.Parse(Console.ReadLine());
            }
            else if (tipoPessoa == 2)
            {
                Console.Write("CNPJ (Máximo 14 dígitos): ");
                cnpj = Console.ReadLine();
            }


            var pessoa = new PessoaDTO(nome, email, contato, cpf, cnpj)
            {
                DataCriacao = DateTime.Now,
            };

            var pessoaRepositorio = new PessoaRepositorio();
            var cadastrarPessoaUseCase = new CadastrarPessoaUseCase(pessoaRepositorio);
            cadastrarPessoaUseCase.Executar(pessoa);

            Thread.Sleep(2000);
            Console.Clear();
            MenuInicial.Exibir();
        }
    }
}
