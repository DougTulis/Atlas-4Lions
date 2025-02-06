namespace Projeto_ATLAS___4LIONS.Dominio.Notificacoes
{
    public class Notificacao
    {
        public string Mensagem { get; private set; }
        public string NomePropriedade { get; private set; }

        public Notificacao(string mensagem, string nomePropriedade)
        {
            Mensagem = mensagem;
            NomePropriedade = nomePropriedade;
        }
    }
}
