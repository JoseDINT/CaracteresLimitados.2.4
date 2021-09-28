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

namespace CaracteresLimitados._2._4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void TextoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int CaracteresMaximos = int.Parse(MaximoTextBlock.Text);
            int contadorCaracteres = int.Parse(ContadorTextBlock.Text) + 1;
            int caracteresIntroducidos = TextoTextBox.Text.Length;

            ContadorTextBlock.Text = caracteresIntroducidos.ToString();

            if (contadorCaracteres == CaracteresMaximos)
            { TextoTextBox.IsReadOnly = true;}
                


        }
    }
}
