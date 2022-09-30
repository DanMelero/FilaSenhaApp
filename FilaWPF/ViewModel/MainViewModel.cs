using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FilaWPF.Controls;
using System.Threading.Tasks;

namespace FilaWPF.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel(ChamadaSenhaViewModel chamadaSenhaViewModel, RetiradaSenhaViewModel retiradaSenhaViewModel, MenuControl menuControl)
        {
            ChamadaSenhaViewModel = chamadaSenhaViewModel;
            RetiradaSenhaViewModel = retiradaSenhaViewModel;
            MenuControl = menuControl;
            SelectedViewModel = RetiradaSenhaViewModel;
        }

        [ObservableProperty]
        private ObservableObject? _selectedViewModel;

        [ObservableProperty]
        private ChamadaSenhaViewModel? _chamadaSenhaViewModel;

        [ObservableProperty]
        private RetiradaSenhaViewModel? _retiradaSenhaViewModel;

        [ObservableProperty]
        private MenuControl? _menuControl;

        [RelayCommand]
        private void SelectViewModel(object? parameter)
        {
            SelectedViewModel = parameter as ObservableObject;
        }
    }
}
