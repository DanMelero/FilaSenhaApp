using FilaBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaBackend.Interfaces
{
    public interface IFila
    {

        public void InserirSenhaNaFila(Senha s);

        public void InserirSenhaNaFila(params Senha[] s);

        public string ChamarSenha(string s);

        public string MostrarProximaSenha(string s);

        public int MostrarTamanhoDaFila();
    }
}
