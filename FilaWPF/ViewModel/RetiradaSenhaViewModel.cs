using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FilaBackend.Interfaces;
using FilaBackend.Model;

namespace FilaWPF.ViewModel
{
    public partial class RetiradaSenhaViewModel : ObservableObject
    {
        private readonly IFila _fila;

        public RetiradaSenhaViewModel(IFila fila)
        {
            _fila = fila;
        }

        [ObservableProperty]
        private string? _senhaRetirada;

        [RelayCommand]
        private void RetirarRegular()
        {
            SenhaRetirada = _fila.InserirSenhaNaFila(new Regular());
        }

        [RelayCommand]
        private void RetirarPreferencial()
        {
            SenhaRetirada = _fila.InserirSenhaNaFila(new Preferencial());
        }
    }
}
