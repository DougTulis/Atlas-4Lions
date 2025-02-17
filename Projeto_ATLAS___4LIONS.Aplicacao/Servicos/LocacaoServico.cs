using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Servicos
{
    public class LocacaoService
    {
        private readonly CadastrarLocacaoUseCase _cadastrarLocacaoUseCase;
        private readonly ITabelaPrecoRepositorio _tabelaPrecoRepositorio;

        public LocacaoService(CadastrarLocacaoUseCase cadastrarLocacaoUseCase, ITabelaPrecoRepositorio tabelaPrecoRepositorio)
        {
            _cadastrarLocacaoUseCase = cadastrarLocacaoUseCase;
            _tabelaPrecoRepositorio = tabelaPrecoRepositorio;
        }

        public int CadastrarLocacao(PessoaDTO locatarioDto, PessoaDTO condutorDto, AutomovelDTO automovelDto,
                                    DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao)
        {
            var tabelaPreco = _tabelaPrecoRepositorio.RecuperarPorId(automovelDto.IdPreco?? 0)
    ?? throw new Exception("Preço da diária não encontrado para o automóvel selecionado.");
            // 🔥 1. Criar DTO da Locação
            var locacaoDto = new LocacaoDTO
            {
                Saida = saida,
                Retorno = retorno,
                TipoLocacao = tipoLocacao,
                IdCondutor = condutorDto.Id,
                IdAutomovel = automovelDto.Id,
                IdLocatario = locatarioDto.Id
            };

            // 🔥 2. Chamar o UseCase para processar a locação
            return _cadastrarLocacaoUseCase.Executar(locacaoDto);
        }
    }
}
