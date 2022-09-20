using FilaBackend.Interfaces;

namespace FilaBackend.Model
{
    public class FilaMotor : IFila
    {
        public PriorityQueue<Senha, long> Fila { get; set; } = new();

        private readonly Ordenador _ord;

        public FilaMotor()
        {
            _ord = new(Fila);
        }

        public string InserirSenhaNaFila(Senha senha)
        {
            return AplicarOrdenacao(senha);
        }

        public void InserirSenhaNaFila(params Senha[] senhas)
        {
            foreach (var senha in senhas)
            {
                AplicarOrdenacao(senha);
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

        private string AplicarOrdenacao(Senha senha)
        {
            senha.Numero = _ord.NumerarSenhas(senhaParaSerNumerada: senha, numInicial: 1);
            Fila.Enqueue(senha, _ord.AplicarFatorCorrecao(senhaParaCorrecao: senha, totalSenhasFila: 15));
            return senha.ToString();
        }
    }
}
