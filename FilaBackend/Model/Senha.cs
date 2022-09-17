namespace FilaBackend.Model
{
    public abstract class Senha
    {
        public char Sigla { get; set; }
        public int Numero { get; set; }
        public long Prioridade { get; set; }

        public Senha()
        {
            Prioridade = DateTime.Now.Ticks;
            Thread.Sleep(10);
        }

        public override string ToString()
        {
            return $"{Sigla}{Numero}";
        }
    }
}
