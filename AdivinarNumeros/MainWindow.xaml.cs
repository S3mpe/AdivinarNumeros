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

namespace AdivinarNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numAleatorio;

        public MainWindow()
        {
            InitializeComponent();
        }
        private static int NumeroAleatorio()
        {
            Random aleatorio = new Random();
            int numAleatorio = aleatorio.Next(0, 101);
            return numAleatorio;
        }


        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ResultadoTextBlock.Text = int.Parse(RespuestaTextBox.Text.ToString()) < numAleatorio
                ? "Te has quedado corto."
                : int.Parse(RespuestaTextBox.Text.ToString()) > numAleatorio ? "Te has pasado." : "Has acertado.";
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            NumeroAleatorio();
            RespuestaTextBox.Clear();
            ResultadoTextBlock.Text = "Has reiniciado el número aleatorio.";
        }
    }
}
