using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaBackend.Model
{
    public class Preferencial : Senha
    {
        public Preferencial()
        {
            Sigla = 'P';
            Prioridade *= 0.5;
        }
        public override void CorrigirPrioridade()
        {
            if (FatorCorrecao > 0.7 && FatorCorrecao <= 0.75)
            {
                Prioridade *= 1.88;
            }
            else if (FatorCorrecao > 0.75 && FatorCorrecao <= 0.8)
            {
                Prioridade *= 1.91;
            }
            else if (base.FatorCorrecao > 0.8 && base.FatorCorrecao <= 0.9)
            {
                Prioridade *= 2;
            }
            else if (base.FatorCorrecao > 0.9)
            {
                Prioridade *= 2.2;
            }
            else
            {
                Prioridade *= 1;
            }
        }
    }
}
