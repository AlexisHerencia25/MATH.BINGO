using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using NAudio.Wave;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Bingo
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public void ReproducirMusica()
        {
            
        }
        public Menu()
        {
            InitializeComponent();
        }
        //Evento Clicks
        private void BtnCaller_Click(object sender, RoutedEventArgs e)
        {
            Caller caller = new Caller();
            caller.Show();
            this.Close();
        }

        private void BtnJugador_Click(object sender, RoutedEventArgs e)
        {
            Jugador jugador = new Jugador();
            jugador.Show();
            this.Close();
        }
        //Mouse encima del boton
        private void Encima(object sender, MouseEventArgs e)
        {
            Metodos.SfxBtn();
        }
    }
}
