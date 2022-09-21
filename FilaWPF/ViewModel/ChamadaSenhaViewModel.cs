using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FilaBackend.Interfaces;

namespace FilaWPF.ViewModel
{
    public partial class ChamadaSenhaViewModel : ObservableObject
    {
        private readonly IFila _fila;

        public ChamadaSenhaViewModel(IFila fila)
        {
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
