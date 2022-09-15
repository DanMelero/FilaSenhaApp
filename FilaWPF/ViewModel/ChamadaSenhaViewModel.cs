using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FilaBackend.Interfaces;
using FilaBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaWPF.ViewModel
{
    public partial class ChamadaSenhaViewModel : ObservableObject
    {
        private readonly IFila _fila;

        public ChamadaSenhaViewModel(IFila fila)
        {
            fila.InserirSenhaNaFila(new Regular(), new Preferencial(), new Preferencial(), new Preferencial(), new Preferencial(), new Regular(), new Preferencial(), new Preferencial());
            _fila = fila;
            _senhaChamada = SenhaChamada;
        }

        [ObservableProperty]
        private string? _senhaChamada;
        [ObservableProperty]
        private string? _proximaSenha;
        [ObservableProperty]
        private string? _tamanhoFila;

        [RelayCommand]
        private void AtivarProxSenha()
        {
            SenhaChamada = _fila.ChamarSenha("sem fila");
            ProximaSenha = _fila.MostrarProximaSenha("-");
            TamanhoFila = _fila.MostrarTamanhoDaFila().ToString();
        }
    }
}
