using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class AtualizarDadosPessoaUseCase : IAtualizarDadosPessoaUseCase
    {

        private readonly IPessoaRepositorio _pessoaRepositorio;

        public AtualizarDadosPessoaUseCase(IPessoaRepositorio pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }

        public RespostaPadrao<string> Executar<T>(PessoaDTO pessoaDto, string campoBanco,string campoSelecionado, T dados)
        {

            var pessoa = Pessoa.CreateFromDataBase(pessoaDto.Id,
                pessoaDto.DataCriacao,
                pessoaDto.Nome,
                pessoaDto.Email,
                pessoaDto.Contato,
                pessoaDto.TipoPessoa,
                pessoaDto.NumeroDocumento,
                pessoaDto.DataRegistro,
                pessoaDto.NumeroCnh,
                pessoaDto.VencimentoCnh);

            switch (campoBanco)
            {
                case "nome":
                    pessoa.AlterarNome(dados.ToString());
                    break;
                case "email":
                    pessoa.AlterarEmail(dados.ToString());
                    if (_pessoaRepositorio.EmailExiste(pessoa.Email))
                    {
                        return RespostaPadrao<string>.Falha(false, "Cadastro de Pessoas", "Email ja cadastrado!");
                    }

                    break;
                case "contato":
                    pessoa.AlterarContato(dados.ToString());
                    break;
                case "numero_documento":
                    pessoa.AlterarNumeroDocumento(dados.ToString());

                    if (_pessoaRepositorio.NumeroDocumentoExiste(pessoa.NumeroDocumento))
                    {
                        return RespostaPadrao<string>.Falha(false, "Cadastro de Pessoas", "CPF/CNPJ ja cadastrado!");
                    }

                    break;
            }
            if (!pessoa.Validacao(out string erros))
            {
                return RespostaPadrao<string>.Falha(false, "Edição de pessoas", erros);
            }
            _pessoaRepositorio.AtualizarDados(pessoa.Id, campoBanco, dados);

            return RespostaPadrao<string>.Sucesso(true, "Edição de pessoas", $"{campoSelecionado} atualizado com sucesso!");
        }

    }
}
