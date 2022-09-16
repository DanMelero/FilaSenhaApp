namespace FilaBackend.Model
{
    public class Ordenador
    {
        private readonly PriorityQueue<Senha, double> _fila;

        public Dictionary<string, int> ContTipos { get; set; } = new();

        public Ordenador(PriorityQueue<Senha, double> fila)
        {
            _fila = fila;
        }

        public void AplicarFatorCorrecao(Senha senhaParaCorrecao, int totalSenhasFila)
        {
            var correcao = _fila.Count >= totalSenhasFila ? (double)_fila.UnorderedItems.Count(t => t.Element.GetType().Name == senhaParaCorrecao.GetType().Name) / _fila.Count : 1;
            senhaParaCorrecao.Prioridade = correcao >= 0.8 ? senhaParaCorrecao.Prioridade *= 1.00002 : 1;
        }

        public int NumerarSenhas(Senha senhaParaSerNumerada, int numInicial)
        {
            string tipoSenha = senhaParaSerNumerada.GetType().Name;
            if (ContTipos.ContainsKey(tipoSenha))
            {
                ++ContTipos[tipoSenha];
            }
            else
            {
                ContTipos.Add(tipoSenha, numInicial++);
            }
            return ContTipos[tipoSenha];
        }
    }
}
