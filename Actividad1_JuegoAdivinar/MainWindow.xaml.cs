using System;
using System.Windows;


namespace Actividad1_JuegoAdivinar
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numeroGenerado;
        public MainWindow()
        {
            InitializeComponent();
            numeroGenerado = GenerarNumAleatorio();
        }
        private int GenerarNumAleatorio()
        {
            Random seed = new Random();
            return seed.Next(0, 101);
        }
        private void comprobarButton_Click(object sender, RoutedEventArgs e)
        {
            int numUser = int.Parse(numeroUserTextBox.Text);
            if (numUser == numeroGenerado)
                mensajeTextBlock.Text = "¡CORRECTO!";
            else if (numUser < numeroGenerado)
                mensajeTextBlock.Text = "Te has quedado corto";
            else
                mensajeTextBlock.Text = "Te has pasado";  
        }

        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numeroGenerado = GenerarNumAleatorio();
            mensajeTextBlock.Text = "";
            numeroUserTextBox.Text = "";
        }
    }
}
