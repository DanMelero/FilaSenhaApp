using FilaBackend.Interfaces;

namespace FilaBackend.Model
{
    public class Configuracao : IConfiguracao
    {
        private double _porcMesmoTipo;
        public int NumInicial { get; set; }
        public bool FatorCorrecao { get; set; }
        public int NumSenhas { get; set; }

        public double PorcMesmoTipo
        {
            get { return _porcMesmoTipo/100; }
            set { _porcMesmoTipo = value; } 
        }

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
            FatorCorrecao = false;
            NumSenhas = 15;
            PorcMesmoTipo = 80;
        }
    }
}
