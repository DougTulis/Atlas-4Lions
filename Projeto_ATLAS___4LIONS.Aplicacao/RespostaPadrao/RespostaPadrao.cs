using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao
{
    public class RespostaPadrao<T>
    {

        public bool Procede { get; set; }
        public string Mensagem { get; set; }
        public T? Dados { get; set; }

        public RespostaPadrao(bool procede, string mensagem, T dados)
        {
            Procede = procede;
            Mensagem = mensagem;
            Dados = dados;
        }

        public static RespostaPadrao<T> Sucesso(bool procede, string mensagem, T dados = default)
        {
            return new RespostaPadrao<T>(true, mensagem, dados);
        }

        public static RespostaPadrao<T> Falha(bool procede, string mensagem, T dados = default)
        {
            return new RespostaPadrao<T>(false, mensagem, dados);
        }
    }


}
