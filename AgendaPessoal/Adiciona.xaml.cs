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
using AgendaPessoal.Data;
using AgendaPessoal.Models;

namespace AgendaPessoal
{
    /// <summary>
    /// Lógica interna para Adiciona.xaml
    /// </summary>
    public partial class Adiciona : Window
    {
        public Adiciona()
        {
            InitializeComponent();
        }

        private void btnCadastrarNovoLembrete_Click(object sender, RoutedEventArgs e)
        {
            //Implementar o Adicionar lembrete
            Lembrete objLembrete = new Lembrete(txtNome.Text, Convert.ToDateTime(txtData.Text), txtDescricao.Text, txtTelefone.Text, txtEmail.Text);
            objLembrete.mtdInsert(objLembrete);
            //Redireciona para ver todos os lembretes
            var frmRedirectToBusca = new Busca();
            frmRedirectToBusca.Show();
            //Fecha a janela de adicionar
            Close();
        }

        private void txtDescricao_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtData_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
