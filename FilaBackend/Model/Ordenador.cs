using FilaBackend.Interfaces;

namespace FilaBackend.Model
{
    internal class Ordenador
    {
        private readonly IConfiguracao _configuracao;
        private readonly PriorityQueue<Senha, long> _fila;

        private Dictionary<string, int> ContTipos { get; set; } = new();

        internal Ordenador(PriorityQueue<Senha, long> fila, IConfiguracao configuracao)
        {
            _configuracao = configuracao;
            _fila = fila;
        }

        internal string AplicarOrdenacao(Senha senha)
        {
            senha.Numero = NumerarSenhas(senha);
            _fila.Enqueue(senha, AplicarFatorCorrecao(senha));
            return senha.ToString();
        }

        private long AplicarFatorCorrecao(Senha senhaParaCorrecao)
        {
            var tipoSenha = senhaParaCorrecao.GetType().Name;
            var correcao = _fila.Count >= _configuracao.NumSenhas ? (double)_fila.UnorderedItems.Count(t => t.Element.GetType().Name == tipoSenha) / _fila.Count : 1;
            return correcao >= _configuracao.PorcMesmoTipo && _configuracao.FatorCorrecao ? senhaParaCorrecao.Prioridade / 2 : senhaParaCorrecao.Prioridade;
        }

        private int NumerarSenhas(Senha senhaParaSerNumerada)
        {
            string tipoSenha = senhaParaSerNumerada.GetType().Name;
            if (ContTipos.ContainsKey(tipoSenha))
            {
                ContTipos[tipoSenha]++;
            }
            else
            {
                ContTipos.Add(tipoSenha, _configuracao.NumInicial);
            }
            return ContTipos[tipoSenha];
        }
    }

}
