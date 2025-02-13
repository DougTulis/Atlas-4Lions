using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;


namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface
{
    public interface ILocacaoRepositorio
    {
        public IEnumerable<LocacaoDTO> ListarTodos();

        public IEnumerable<LocacaoDTO> PopularLista(MySqlDataReader dataReader);
        public int Adicionar(LocacaoDTO objeto, Pessoa condutorDto, Pessoa locatario,Automovel automovel);
        public void Deletar(LocacaoDTO objeto);
        public LocacaoDTO? RecuperarPorId(int id);
        public IEnumerable<LocacaoDTO> ListarPorStatusAndamento();
        public void AtualizarStatus(int locacaoId, EStatusLocacao novoStatus);
    }
}
