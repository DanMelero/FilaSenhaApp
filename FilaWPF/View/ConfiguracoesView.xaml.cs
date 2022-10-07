using System.Windows;
using System.Windows.Controls;

namespace FilaWPF.View
{
    public partial class ConfiguracoesView : UserControl
    {
        public ConfiguracoesView()
        {
            InitializeComponent();
        }

        private void Salvar_Click(object sender, RoutedEventArgs e)
        {
            StackPanelMsgSaved.Visibility = Visibility.Visible;
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            StackPanelMsgSaved.Visibility = Visibility.Collapsed;
        }
    }
}
