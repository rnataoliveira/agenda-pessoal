using AgendaPessoal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AgendaPessoal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdicionarLembrete_Click(object sender, RoutedEventArgs e)
        {
            //Ao clicar no botão redireciona para a página de adicionar lembrete
            var frmAdiciona = new Adiciona();
            frmAdiciona.Show();
            Close();
        }

        private void btnVerLembrete_Click(object sender, RoutedEventArgs e)
        {
            //Ao clicar no botão redireciona para a página de Ver Lembretes
            var frmVerLembretes = new VerLembretes();
            frmVerLembretes.Show();
            Close();
        }

        private void btnBuscarLembrete_Click(object sender, RoutedEventArgs e)
        {
            //Ao clicar no botão redireciona para a página de buscar lembrete
            var frmBuscarLembrete = new Busca();
            frmBuscarLembrete.Show();
            Close();

        }
    }
}
