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
        private readonly IConfiguracao _configuracao;
        public MainWindow()
        {
            _configuracao = new Configuracao();
            _fila = new FilaMotor(_configuracao);
            InitializeComponent();
            _viewModel = new MainViewModel(new ChamadaSenhaViewModel(_fila), new RetiradaSenhaViewModel(_fila), new Controls.MenuControl(), new ConfiguracaoViewModel(_configuracao));
            DataContext = _viewModel;
        }
    }
}
