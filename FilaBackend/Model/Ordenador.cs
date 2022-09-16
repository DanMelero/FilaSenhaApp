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

        //public void AplicarFatorCorrecao(Senha senhaParaCorrecao, int numPessoasNaFila)
        //{
        //    if (_fila.Count >= numPessoasNaFila)
        //    {
        //        var prioridadeCorrigida = ContTipos.ContainsKey(senhaParaCorrecao.GetType().Name) ? (double)_fila.UnorderedItems.Count(t => t.Element.GetType().Name == senhaParaCorrecao.GetType().Name) / _fila.Count : 1;
        //    }
        //}

        public int NumerarSenhas (Senha senhaParaSerNumerada, int numInicial)
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
