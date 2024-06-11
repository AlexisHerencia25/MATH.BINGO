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
using System.Windows.Media.Animation;
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
        private List<int> lista_binarios = new List<int>();
        private Controles controles = new Controles();
        public Caller()
        {
            InitializeComponent();
            Metodos.SFXIntro();
        }

        private async void BtnGenerar_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string numerobinario = "";
            int numero = random.Next(65, 91);
            lista_binarios.Add(numero);
            while (numero > 0)
            {
                numerobinario += numero % 2;
                numero /= 2;
            }
            numerobinario.Reverse();
            char[] digitosbinarios = numerobinario.ToCharArray();
            foreach (int n in new int[] { 1, 2, 3, 4, 5, 6, 7 })
            {
                TextBox textBox = (TextBox)FindName($"NB{n}");
                textBox.Text = $"{digitosbinarios[n - 1]}";
                Storyboard storyboard = (Storyboard)FindResource("GirarWrapPanel");
                storyboard.Begin(textBox);
                Metodos.SfxFlip();
                await Task.Delay(150);
            }
            TextBox lista = (TextBox)FindName("ListaDeNumeros");
            if (lista.Text == "")
                lista.Text += $"{numerobinario}";
            else
                lista.Text += $", {numerobinario}";
            Metodos.SfxTxt();
        }

        private void BtnGenerar_Encima(object sender, MouseEventArgs e)
        {
            Metodos.SfxBtn();
        }

        private async void BtnAlfGenerar_Click(object sender, RoutedEventArgs e)
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
                    textbox.Width = 28.4;
                    textbox.Height = 45.7;
                    textbox.IsReadOnly = true;
                    textbox.BorderThickness = new Thickness(0);
                    textbox.FontSize = 28;
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
                    Storyboard storyboard = (Storyboard)FindResource("GirarWrapPanel");
                    storyboard.Begin(wrapPanel);
                    Metodos.SfxFlip();
                    await Task.Delay(150);
                }
            }

        }
    }
}
