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
                    if (alf != 'C' || num != 3)
                    {
                        int LetraASCII;
                        if (random.Next(0, 2) == 0)
                        {
                            LetraASCII = random.Next(65, 91);
                        }
                        else
                            LetraASCII = random.Next(97, 123);
                        TextBlock textBlock = new TextBlock();
                        textBlock.FontSize = 28;
                        textBlock.HorizontalAlignment = HorizontalAlignment.Center;
                        textBlock.VerticalAlignment = VerticalAlignment.Center;
                        textBlock.Text = LetraASCII.ToString();
                        textBlock.FontFamily = new FontFamily("Showcard Gothic");
                        textBlock.Margin = new Thickness(10, 9, 0, 0);
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
}