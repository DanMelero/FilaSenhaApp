using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FilaBackend.Interfaces;

namespace FilaWPF.ViewModel
{
    public partial class ConfiguracaoViewModel : ObservableObject
    {
        private readonly IConfiguracao _configuracao;
        public ConfiguracaoViewModel(IConfiguracao fila)
        {
            _configuracao = fila;
        }

        [ObservableProperty]
        private int _numInicial;
        [ObservableProperty]
        private bool _fatorCorrecao;
        [ObservableProperty]
        private int _numSenhas;
        [ObservableProperty]
        private double _porcentagemMesmoTipo;

        [RelayCommand]
        private void Salvar()
        {
            _configuracao.NumInicial = NumInicial;
            _configuracao.FatorCorrecao = FatorCorrecao;
            _configuracao.NumSenhas = NumSenhas;
            _configuracao.NumInicial = NumInicial;
        }
    }
}
