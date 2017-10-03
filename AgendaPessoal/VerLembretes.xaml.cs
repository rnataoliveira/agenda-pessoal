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
using AgendaPessoal.Models;
using AgendaPessoal.Data;
using System.Data;
using System.Collections.ObjectModel;

namespace AgendaPessoal
{
    /// <summary>
    /// Lógica interna para VerLembretes.xaml
    /// </summary>
    public partial class VerLembretes : Window
    {
        string conteudo;
        public VerLembretes(string conteudo)
        {
            this.conteudo = conteudo;
            InitializeComponent();

            Lembrete objLembrete = new Lembrete();
            objLembrete = objLembrete.MtdSelectConteudo(conteudo);
            txtNomeLembrete.Text = objLembrete.StrNome;
            txtDataLembrete.Text = objLembrete.StrData.ToString();
        }

        public VerLembretes()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (this.conteudo != null)
            {
                Lembrete objLembrete = new Lembrete();
                objLembrete = objLembrete.MtdSelectConteudo(this.conteudo);
                txtNomeLembrete.Text = objLembrete.StrNome;
                txtDataLembrete.Text = objLembrete.StrData.ToString();
            }
            else
            {
                Lembrete objLembrete = new Lembrete();
                var lembrete = objLembrete.MtdSelect();
                txtNomeLembrete.Text = lembrete.StrNome;
                txtDataLembrete.Text = lembrete.StrData.ToString();
            }
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            var frmInicio = new MainWindow();
            frmInicio.Show();
            Close();
        }
    }
}
