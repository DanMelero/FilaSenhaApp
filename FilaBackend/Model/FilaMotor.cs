using FilaBackend.Interfaces;

namespace FilaBackend.Model
{
    public class FilaMotor : IFila
    {
        public PriorityQueue<Senha, long> Fila { get; set; } = new();

        private readonly Ordenador _ord;

        public FilaMotor(IConfiguracao configuracao)
        {
            _ord = new(Fila, configuracao);
        }

        public string InserirSenhaNaFila(Senha senha)
        {
            return _ord.AplicarOrdenacao(senha);
        }

        public void InserirSenhaNaFila(params Senha[] senhas)
        {
            foreach (var senha in senhas)
            {
               _ord.AplicarOrdenacao(senha);
            }
        }

        public string ChamarSenha(string semSenha)
        {
            return Fila.TryDequeue(out var proxSenha, out _) ? proxSenha.ToString() : semSenha;
        }

        public string MostrarProximaSenha(string semSenha)
        {
            return Fila.TryPeek(out var proxSenha, out _) ? proxSenha.ToString() : semSenha;
        }

        public int MostrarTamanhoDaFila()
        {
            return Fila.Count > 0 ? Fila.Count : 0;
        }
    }
}
