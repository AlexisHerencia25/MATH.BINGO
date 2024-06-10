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
            Metodos.SFXIntro();
        }

        private void BtnGenerar_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            //controles.rndN = (TextBox)FindName("TxtRnd");
            //controles.rndN.Text = $"{random.Next(65, 91)}";
            int numero = random.Next(65, 91);
            TxtRnd.Text = "";
            while (numero > 0)
            {
                TxtRnd.Text += numero % 2;
                numero /= 2;
            }
            Metodos.SfxTxt();
        }

        private void BtnGenerar_Encima(object sender, MouseEventArgs e)
        {
            Metodos.SfxBtn();
        }

        private void BtnAlfGenerar_Click(object sender, RoutedEventArgs e)
        {
            Metodos.SfxTxt();
            Random random = new Random();
            foreach (char alf in new char[4] { 'A', 'B', 'C', 'D' })
            {
                foreach (int num in new int[4] { 1, 2, 3, 4 })
                {
                    int Letra;
                    Letra = random.Next(0, 26);
                    TextBox textbox = new TextBox();
                    textbox.Width = 58.4;
                    textbox.Height = 60.7;
                    textbox.IsReadOnly = true;
                    textbox.BorderThickness = new Thickness(0);
                    textbox.FontSize = 38;
                    textbox.TextAlignment = TextAlignment.Center;
                    textbox.HorizontalAlignment = HorizontalAlignment.Center;
                    textbox.VerticalAlignment = VerticalAlignment.Center;
                    textbox.Text = $"{(char)('A' + Letra)}";
                    textbox.FontFamily = new FontFamily("Cassia");
                    textbox.Margin = new Thickness(12, 15, 0, 0);
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
