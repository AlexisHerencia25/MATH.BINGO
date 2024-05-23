using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using NAudio.Wave;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Bingo
{
    public class Metodos : Window
    {
        public static void MusicaDeFondo()
        {
            TimeSpan terminar = new TimeSpan(0, 0, 0, 9, 92);
            
            MediaElement cancion = new MediaElement();
            cancion.Source = new Uri($"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory)}\\Music\\Let's be Honest.wav");
            
        }
        public static void SfxBtn()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = $"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory)}\\SFX\\Slide.wav";
            soundPlayer.Load(); soundPlayer.Play();
        }
    }
}
