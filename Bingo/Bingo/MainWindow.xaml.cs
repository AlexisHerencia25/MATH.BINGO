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

namespace Bingo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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
                    char letraAleatoria = (char)('A' + new Random().Next(26));
                    TextBlock textBlock = new TextBlock();
                    textBlock.FontSize = 35;
                    textBlock.HorizontalAlignment = HorizontalAlignment.Center;
                    textBlock.VerticalAlignment = VerticalAlignment.Center;
                    textBlock.Text = letraAleatoria.ToString();
                    textBlock.FontFamily = new FontFamily("Showcard Gothic");
                    WrapPanel wrapPanel = (WrapPanel)FindName($"{alf}{num}");
                    if (wrapPanel.Children.Count != 0)
                    {
                        wrapPanel.Children.RemoveAt(0);
                        wrapPanel.Children.Add(textBlock);
                    }
                    else
                        wrapPanel.Children.Add(textBlock);
                }
            }
        }
    }
}