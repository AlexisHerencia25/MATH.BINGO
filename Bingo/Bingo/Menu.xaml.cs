﻿using System;
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
using System.Windows.Media.Animation;
using System.Windows.Threading;

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
            BackgroundMusic.UnloadedBehavior = MediaState.Manual;
            BingoIMG.RenderTransform = new TranslateTransform();
            this.Width = 1000;
            this.Height = 563;
        }
        //Evento Clicks
        private void BtnCaller_Click(object sender, RoutedEventArgs e)
        {
            Caller caller = new Caller();
            caller.ShowDialog();
            
        }
        //Mouse encima del boton
        private void Encima(object sender, MouseEventArgs e)
        {
            Storyboard deslizarinfo = (Storyboard)FindResource("CallerDeslizarAbajo");
            deslizarinfo.Begin();
            Metodos.SfxBtn();
        }

        private void Dejar(object sender, MouseEventArgs e)
        {
            Storyboard sb = (Storyboard)FindResource("CallerDeslizarArriba");
            sb.Begin();
        }

        private void EncimaJugador(object sender, MouseEventArgs e)
        {
            Storyboard deslizarinfo = (Storyboard)FindResource("JugadorDeslizarAbajo");
            deslizarinfo.Begin();
            Metodos.SfxBtn();
        }

        private void DejarJugador(object sender, MouseEventArgs e)
        {
            Storyboard deslizarinfo = (Storyboard)FindResource("JugadorDeslizarArriba");
            deslizarinfo.Begin();
        }

        private void HyperLink_Click(object sender, RoutedEventArgs e)
        {
            Jugador jugador = new Jugador();
            jugador.ShowDialog();
        }

        private void EncimaLinkLabel(object sender, MouseEventArgs e)
        {
            Metodos.SfxBtn();
        }

        private void RepetirMusica(object sender, RoutedEventArgs e)
        {
                BackgroundMusic.Position = new TimeSpan(0, 0, 0, 19, 99);
                BackgroundMusic.Play();
        }
    }
}
