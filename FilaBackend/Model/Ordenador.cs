using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void AplicarFatorCorrecao(Senha s)
        {
            s.FatorCorrecao = (double)_fila.UnorderedItems.Count(t => t.Element.GetType().Name == s.GetType().Name) / _fila.Count;
            s.CorrigirPrioridade();
        }

        public int NumerarSenhas (Senha s, int valorInicial)
        {
            string tipoSenha = s.GetType().Name;
            if (ContTipos.ContainsKey(tipoSenha))
            {
                ContTipos[tipoSenha]++;
            }
            else
            {
                ContTipos.Add(tipoSenha, valorInicial++);
            }
            return ContTipos[tipoSenha];
        }
    }
}
