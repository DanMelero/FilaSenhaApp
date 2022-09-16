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
            senha.Numero = _ord.NumerarSenhas(senhaParaSerNumerada: senha, numInicial: 1); ;
            //_ord.AplicarFatorCorrecao(senhaParaCorrecao: senha, numPessoasNaFila: 20);
            Fila.Enqueue(senha, senha.Prioridade);
        }

        public void InserirSenhaNaFila(params Senha[] senhas)
        {
            foreach (var senha in senhas)
            {
                senha.Numero = _ord.NumerarSenhas(senhaParaSerNumerada: senha, numInicial: 1);
                _ord.AplicarFatorCorrecao(senhaParaCorrecao: senha, totalSenhasFila: 15);
                Fila.Enqueue(senha, senha.Prioridade);
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
