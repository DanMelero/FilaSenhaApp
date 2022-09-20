using FilaBackend.Model;

namespace FilaBackend.Interfaces
{
    public interface IFila
    {

        public string InserirSenhaNaFila(Senha s);

        public void InserirSenhaNaFila(params Senha[] s);

        public string ChamarSenha(string s);

        public string MostrarProximaSenha(string s);

        public int MostrarTamanhoDaFila();
    }
}
