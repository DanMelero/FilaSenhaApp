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

        public Ordenador(PriorityQueue<Senha, double> fila)
        {
            _fila = fila;
        }

        public void AplicarFatorCorrecao(Senha s)
        {
            s.FatorCorrecao = (double)_fila.UnorderedItems.Count(t => t.Element.GetType().Name == s.GetType().Name) / _fila.Count;
            s.CorrigirPrioridade();
        }
    }
}
