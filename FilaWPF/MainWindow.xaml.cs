using FilaBackend.Interfaces;
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
        private readonly MainViewModel _viewModel;
        private readonly IFila _fila;

        public MainWindow()
        {
            _fila = new FilaMotor();
            InitializeComponent();
            _viewModel = new MainViewModel(new ChamadaSenhaViewModel(_fila), new RetiradaSenhaViewModel(_fila));
            DataContext = _viewModel;
        }
    }
}
