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
        
        public Jugador()
        {
            InitializeComponent();
        }

        private void TerminarCancion(object sender, RoutedEventArgs e)
        {
            BackgroundMusic.Position = TimeSpan.Zero;
            BackgroundMusic.Play();
        }
        private void BtnGenerar_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            foreach (char alf in new char[5] {'A', 'B', 'C', 'D', 'E'})
            {
                foreach (int num in new int[5] {1, 2, 3, 4, 5})
                {
                    if (alf != 'C' || num != 3)
                    {
                        int LetraASCII;
                        if (random.Next(0, 2) == 0)
                        {
                            LetraASCII = random.Next(65, 91);
                        }
                        else
                            LetraASCII = random.Next(97, 123);
                        TextBox textbox = new TextBox();
                        textbox.Width = 58.4;
                        textbox.Height = 55.7;
                        textbox.FontSize = 28;
                        textbox.TextAlignment = TextAlignment.Center;
                        textbox.HorizontalAlignment = HorizontalAlignment.Center;
                        textbox.VerticalAlignment = VerticalAlignment.Center;
                        textbox.Text = LetraASCII.ToString();
                        textbox.FontFamily = new FontFamily("Showcard Gothic");
                        textbox.Margin = new Thickness(0, 16, 0, 0);
                        WrapPanel wrapPanel = (WrapPanel)FindName($"{alf}{num}");
                        if (wrapPanel.Children.Count != 0)
                        {
                            wrapPanel.Children.RemoveAt(0);
                            wrapPanel.Children.Add(textbox);
                        }
                        else
                            wrapPanel.Children.Add(textbox); 
                    }
                }
            }
        }
    }
}