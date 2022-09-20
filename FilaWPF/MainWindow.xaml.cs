using FilaBackend.Model;
using FilaWPF.ViewModel;
using System.Windows;

namespace FilaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private readonly ChamadaSenhaViewModel _viewModel;
        private readonly RetiradaSenhaViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new RetiradaSenhaViewModel(new FilaMotor());
            DataContext = _viewModel;
        }
    }
}
