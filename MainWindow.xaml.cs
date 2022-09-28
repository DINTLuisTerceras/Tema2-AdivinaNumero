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

namespace ejercicio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numeroSecreto;
        private Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            numeroSecreto = random.Next(1, 101);
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(numberTextBox.Text) == numeroSecreto)
            {
                pistaTextBlock.Text = "Has acertado";
            }
            if (int.Parse(numberTextBox.Text) > numeroSecreto)
            {
                pistaTextBlock.Text = "Te has pasado";
            }
            if (int.Parse(numberTextBox.Text) < numeroSecreto)
            {
                pistaTextBlock.Text = "Te has quedado corto";
            }
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            pistaTextBlock.Text = "";
            numberTextBox.Text = "";

            numeroSecreto = random.Next(1, 101);
        }
    }
}
