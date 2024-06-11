using System.Text;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection.PortableExecutable;

namespace Bingo
{
    /// <summary>
    /// Interaction logic for Jugador.xaml
    /// </summary>
    public partial class Jugador : Window
    {
        private string[] Pequeñas_Oraciones = { "El perro ladró fuerte", 
                                                "La ventana se rompió", 
                                                "Comimos pizza ayer", 
                                                "El coche es rojo", 
                                                "Llueve en la ciudad",
                                                "Las flores son bonitas",
                                                "El niño juega afuera",
                                                "La luna está llena",
                                                "El gato duerme mucho",
                                                "La pelota rebotó lejos"};
        public Jugador()
        {
            InitializeComponent();
            Metodos.SFXIntro();
        } 
    }
}