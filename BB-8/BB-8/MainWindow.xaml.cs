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
using System.IO;
using System.Windows.Shapes;

namespace BB_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Complexidade;
        string Impacto;
        string Ambiente;
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtGerado.Content = "Macro Copiada!";

            //Complexidade
            if (rdbComplexidade1.IsChecked == true)
            {
                Complexidade = "1(BAIXO)";
            }
            else if (rdbComplexidade2.IsChecked == true)
            {
                Complexidade = "2(MÉDIO)";
            }
            else if (rdbComplexidade3.IsChecked == true)
            {
                Complexidade = "3(ALTO)";
            };

            //Impacto
            if (rdbImpacto0.IsChecked == true)
            {
                Impacto = "0(NÃO AFETA)";
            }
            else if (rdbImpacto1.IsChecked == true)
            {
                Impacto = "1 (AFETA)";
            }

            //Ambiente
            if (rdbAmbiente1.IsChecked == true)
            {
                Ambiente = "1(SIM)";
            }
            else if (rdbAmbiente2.IsChecked == true)
            {
                Ambiente = "2(NÃO)";
            }
            



            CopiarArquivo();
        }

        public void CopiarArquivo()
        {
            Clipboard.SetText($"Descrição : {txtDescricao.Text}\nTratativa : {txtTratativa.Text}\nComplexidade de desenvolvimento : {Complexidade}\nNível impacto em outras telas : {Impacto}\nComportamento esperado : {txtComportamento.Text}\n Ambiente de teste : {Ambiente}\nExemplo de cenário de testes: {txtAmbiente.Text}  ");
            
            

        }
    }
}
