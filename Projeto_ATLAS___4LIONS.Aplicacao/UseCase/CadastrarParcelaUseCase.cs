using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarParcelaUseCase
    {
        private readonly IParcelaRepositorio parcelaRepositorio;
        public CadastrarParcelaUseCase(IParcelaRepositorio parcelaRepositorio)
        {
            this.parcelaRepositorio = parcelaRepositorio;
        }
        public void Executar(ParcelaDTO parcelaDto)
        {
            try
            {
                var parcela = Parcela.Create(parcelaDto.Sequencia, parcelaDto.DataVencimento, parcelaDto.Valor);

                if (!parcela.Validacao())
                {
                    return;
                }
                parcelaRepositorio.Adicionar(parcela);
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
    }
}
