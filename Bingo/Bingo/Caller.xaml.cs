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
using static Bingo.Estructura;

namespace Bingo
{
    
    /// <summary>
    /// Lógica de interacción para Caller.xaml
    /// </summary>
    public partial class Caller : Window
    {
        private Controles controles = new Controles();
        public Caller()
        {
            InitializeComponent();
        }

        private void BtnGenerar_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            controles.rndN = (TextBox)FindName("TxtRnd");
            controles.rndN.Text = $"{(char)('A' + random.Next(0, 26))}";
        }
    }
}
