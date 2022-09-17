namespace FilaBackend.Model
{
    public class Ordenador
    {
        private readonly PriorityQueue<Senha, long> _fila;

        public Dictionary<string, int> ContTipos { get; set; } = new();

        public Ordenador(PriorityQueue<Senha, long> fila)
        {
            _fila = fila;
        }

        public long AplicarFatorCorrecao(Senha senhaParaCorrecao, int totalSenhasFila)
        {
            var tipoSenha = senhaParaCorrecao.GetType().Name;
            var correcao = _fila.Count >= totalSenhasFila ? (double)_fila.UnorderedItems.Count(t => t.Element.GetType().Name == tipoSenha) / _fila.Count : 1;
            return correcao >= 0.8  ? senhaParaCorrecao.Prioridade-- : senhaParaCorrecao.Prioridade;
        }

        public int NumerarSenhas(Senha senhaParaSerNumerada, int numInicial)
        {
            string tipoSenha = senhaParaSerNumerada.GetType().Name;
            if (ContTipos.ContainsKey(tipoSenha))
            {
                ContTipos[tipoSenha]++;
            }
            else
            {
                ContTipos.Add(tipoSenha, numInicial);
            }
            return ContTipos[tipoSenha];
        }
    }
}
