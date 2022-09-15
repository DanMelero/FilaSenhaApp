using FilaBackend.Interfaces;

namespace FilaBackend.Model
{
    public class FilaMotor : IFila
    {
        public PriorityQueue<Senha, double> Fila { get; set; } = new();

        private readonly Ordenador _ord;

        public FilaMotor()
        {
            _ord = new(Fila);
        }

        public void InserirSenhaNaFila(Senha senha)
        {
            senha.Numero = _ord.NumerarSenhas(senha, 1);
            _ord.AplicarFatorCorrecao(senha);
            Fila.Enqueue(senha, senha.Prioridade);
        }

        public void InserirSenhaNaFila(params Senha[] senhas)
        {
            foreach (var item in senhas)
            {
                item.Numero = _ord.NumerarSenhas(item, 1);
                _ord.AplicarFatorCorrecao(item);
                Fila.Enqueue(item, item.Prioridade);
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
