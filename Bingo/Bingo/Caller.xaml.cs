﻿using System;
using System.IO;
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
using System.Diagnostics;
using static Bingo.Estructura;

namespace Bingo
{

    /// <summary>
    /// Lógica de interacción para Caller.xaml
    /// </summary>
    public partial class Caller : Window
    {
        private static Stopwatch stopwatch = new Stopwatch();
        private List<int> lista_binarios = new List<int>();
        private Controles controles = new Controles();
        private bool[] letrasmarcadas = new bool[17] { false, false , false , false , false , false , false , false , false , false , false , false , false , false , false , false , false };
        private bool activarBINGO = false;
        public Caller()
        {
            InitializeComponent();
            Metodos.SFXIntro();
            stopwatch.Start();
        }

        private async void BtnGenerar_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string numerobinario = "";
            List<int> bits = new List<int>();
            int numero = random.Next(65, 91);
            int tempnumero = numero;
            lista_binarios.Add(numero);
            while (tempnumero > 0)
            {
                bits.Add(tempnumero % 2);
                tempnumero /= 2;
            }
            bits.Reverse();
            numerobinario = string.Join("", bits);
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
            await Task.Delay(300);
            TextBox lista = (TextBox)FindName("ListaDeNumeros");
            if (lista.Text == "")
                lista.Text += $"{numerobinario}";
            else
                lista.Text += $", {numerobinario}";
            Metodos.SfxTxt();
        }

        private void BtnGenerar_Encima(object sender, MouseEventArgs e) => Metodos.SfxBtn();
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
                    Button button = (Button)FindName($"{alf}{num}Btn");
                    button.IsEnabled = true;
                    button.Opacity = 1;
                }
            }
            await Task.Delay(350);
            Button btngenerar = (Button)FindName("BtnAlfGenerar");
            Canvas contenedor = (Canvas)FindName("Contenedor");
            Metodos.SfxRemove();
            contenedor.Children.Remove(btngenerar);
            await Task.Delay(1000);
            Metodos.SfxSlide();
            GenerarAnimacion();
        }
        private void GenerarAnimacion()
        {
            Image imagen1 = (Image)FindName("IMGConversion");
            Image imagen2 = (Image)FindName("IMGTabla");
            Storyboard aparecer = (Storyboard)FindResource("AparecerEjemplos");
            aparecer.Begin(imagen1);
            aparecer.Begin(imagen2);
        }

        private async void MarcarX(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                foreach (var child in ((StackPanel)button.Content).Children)
                {
                    if (child is Image image)
                        image.Opacity = 1;
                    for (int i = 0; i < letrasmarcadas.Length - 1; i++)
                    {
                        if (letrasmarcadas[i] == false)
                        {
                            letrasmarcadas[i] = true;
                            break;
                        }
                    }
                }
                button.IsEnabled = false;
                if (letrasmarcadas[15] == true)
                {
                    BINGOGANADOR();
                    await Task.Delay(5000);
                    MessageBox.Show("HAS GANADO EL BINGO :D", "ENHORABUENA");
                    TimeSpan elapsed = stopwatch.Elapsed;
                    MessageBox.Show($"Tiempo transcurrido: {elapsed.Minutes}:{elapsed.Seconds}");
                }

            }
        }
        private void BINGOGANADOR()
        {
            Menu menuWindow = Application.Current.Windows.OfType<Menu>().FirstOrDefault();
            menuWindow.Close();
            Storyboard animacion = (Storyboard)FindResource("WINBINGO");
            animacion.Begin(IMGBINGO);
            BINGOOO.Source = new Uri(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Music", "Fanfare.mp3"));
            BINGOOO.Play();
        }

        private void BotonEncimaAlf(object sender, MouseEventArgs e)
        {
            Metodos.SfxBtn();
            if (sender is Button button)
            {
                button.Background = new SolidColorBrush(Colors.Red);
                button.BorderBrush = new SolidColorBrush(Colors.Red);
                button.Opacity = 0.3;
            }
        }

        private void BotonLeaveAlf(object sender, MouseEventArgs e)
        {
            if (sender is Button button)
            {
                button.Background = new SolidColorBrush(Colors.Transparent);
                button.Opacity = 1;
            }
        }
    }
}
