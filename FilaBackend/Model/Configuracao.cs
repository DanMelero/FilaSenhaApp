using FilaBackend.Interfaces;

namespace FilaBackend.Model
{
    public class Configuracao : IConfiguracao
    {
        public int NumInicial { get; set; }
        public bool FatorCorrecao { get; set; }
        public int NumSenhas { get; set; }
        public double PorcMesmoTipo { get; set; }

        public Configuracao(int numInicial, bool fatorCorrecao, int numSenhas, double porcMesmoTipo)
        {
            NumInicial = numInicial;
            FatorCorrecao = fatorCorrecao;
            NumSenhas = numSenhas;
            PorcMesmoTipo = porcMesmoTipo;
        }

        public Configuracao()
        {
            NumInicial = 1;
            FatorCorrecao = true;
            NumSenhas = 15;
            PorcMesmoTipo = 80;
        }
    }
}
