using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FilaBackend.Interfaces;

namespace FilaWPF.ViewModel
{
    public partial class ConfiguracaoViewModel : ObservableObject
    {
        private readonly IConfiguracao _configuracao;
        public ConfiguracaoViewModel(IConfiguracao config)
        {
            _configuracao = config;
            Load();
        }

        [ObservableProperty]
        private int _numInicial;
        [ObservableProperty]
        private bool _fatorCorrecao;
        [ObservableProperty]
        private int _numSenhas;
        [ObservableProperty]
        private string _porcentagemMesmoTipo;

        [RelayCommand]
        private void Salvar()
        {
            _configuracao.NumInicial = NumInicial;
            _configuracao.FatorCorrecao = FatorCorrecao;
            _configuracao.NumSenhas = NumSenhas;
            _configuracao.PorcMesmoTipo = double.Parse(PorcentagemMesmoTipo.Remove(PorcentagemMesmoTipo.LastIndexOf('%')));
        }

        [RelayCommand]
        private void Cancelar()
        {
            Load();
        }

        private void Load()
        {
            NumInicial = _configuracao.NumInicial;
            FatorCorrecao = _configuracao.FatorCorrecao;
            NumSenhas = _configuracao.NumSenhas;
            PorcentagemMesmoTipo = $"{_configuracao.PorcMesmoTipo}%";
        }
    }
}
