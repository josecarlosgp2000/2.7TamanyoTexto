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

namespace TamanyoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GrandeRadioButton.Tag = 45D;
            MedianoRadioButton.Tag = 30D;
            PequenoRadioButton.Tag = 20D;
            MedianoRadioButton.IsChecked = true;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton boton = (RadioButton)sender;
            // TituloTextBlock.FontSize = double.Parse(boton.Tag.ToString()) y en el xaml ponemos en el tag los valores
            TituloTextBlock.FontSize = (double)boton.Tag;
        }
    }
}
