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
using System.Windows.Shapes;

namespace AgendaPessoal
{
    /// <summary>
    /// Lógica interna para Busca.xaml
    /// </summary>
    public partial class Busca : Window
    {
        public Busca()
        {
            InitializeComponent();
        }


        private void btnBuscarLembrete_Click(object sender, RoutedEventArgs e)
        {
            //Implementar a busca dos lembrete antes do redirecionamento

            //Redireciona para a            
            var frmBuscar = new VerLembretes(txtBuscarLembrete.Text);
            frmBuscar.InitializeComponent();
            frmBuscar.Show();
            Close();
        }

        private void txtBuscarLembrete_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
