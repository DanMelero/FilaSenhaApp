namespace FilaBackend.Interfaces
{
    public interface IConfiguracao
    {
        public int NumInicial { get; set; }
        public bool FatorCorrecao { get; set; }
        public int NumSenhas { get; set; }
        public double PorcMesmoTipo { get; set; }

    }
}
