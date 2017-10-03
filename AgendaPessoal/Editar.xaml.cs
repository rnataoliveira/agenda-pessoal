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
    /// Lógica interna para Editar.xaml
    /// </summary>
    public partial class Editar : Window
    {
        public Editar()
        {
            InitializeComponent();
        }

        private void txtEditarNome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtEditarEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtEditarTelefone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtEditarData_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtEditarDescricao_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSalvarEdicao_Click(object sender, RoutedEventArgs e)
        {
            //Implementar a lógica de salvar a edição
            //Redireciona para ver todos os lembretes após salvar a edição
            var frmSalvarAlteracao = new VerLembretes();
            frmSalvarAlteracao.Show();
            Close();
        }
    }
}
