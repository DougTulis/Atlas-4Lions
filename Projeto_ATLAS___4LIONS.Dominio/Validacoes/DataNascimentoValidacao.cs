using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> DataRegistroIsOk(DateTime dataRegistro, int minAno, string mensagem, string propriedadeNome)
        {
            if (dataRegistro == DateTime.MinValue)
            {
                AddNotification(new Notificacao("Data de Registro não pode estar vazia.", propriedadeNome));
            }
            else if (dataRegistro > DateTime.Now || (DateTime.Now.Year - dataRegistro.Year) < minAno)
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }

        public ContratoValidacoes<T> DataNascimentoIsOk(DateTime dataNascimento, int minIdade, string mensagem, string propriedadeNome)
        {
            if (dataNascimento == DateTime.MinValue)
            {
                AddNotification(new Notificacao("Data de Nascimento não pode estar vazia.", propriedadeNome));
            }
            else if (dataNascimento > DateTime.Now || (DateTime.Now.Year - dataNascimento.Year) < minIdade)
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}
