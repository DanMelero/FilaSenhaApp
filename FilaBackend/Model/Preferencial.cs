namespace FilaBackend.Model
{
    public class Preferencial : Senha
    {
        public Preferencial()
        {
            Sigla = 'P';
            Prioridade *= 0.99999;
        }
    }
}
