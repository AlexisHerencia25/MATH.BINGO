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

namespace Bingo
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

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
    }
}
