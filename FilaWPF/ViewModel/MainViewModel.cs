using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace FilaWPF.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel(ChamadaSenhaViewModel chamadaSenhaViewModel, RetiradaSenhaViewModel retiradaSenhaViewModel)
        {
            ChamadaSenhaViewModel = chamadaSenhaViewModel;
            RetiradaSenhaViewModel = retiradaSenhaViewModel;
            SelectedViewModel = RetiradaSenhaViewModel;
        }

        [ObservableProperty]
        private ObservableObject? _selectedViewModel;

        [ObservableProperty]
        private ChamadaSenhaViewModel? _chamadaSenhaViewModel;

        [ObservableProperty]
        private RetiradaSenhaViewModel? _retiradaSenhaViewModel;

        [RelayCommand]
        private void SelectViewModel(object? parameter)
        {
            SelectedViewModel = parameter as ObservableObject;
        }
    }
}
