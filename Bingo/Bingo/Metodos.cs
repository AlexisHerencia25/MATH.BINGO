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
        public static void BackgroundMusic()
        {
            MediaElement metodos = new MediaElement();
            metodos.Source = new Uri($"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory)}\\Music\\Layer Cake.mp3");
            metodos.Play();
        }
        public static void SFXIntro()
        {
            SoundPlayer intro = new SoundPlayer();
            intro.SoundLocation = $"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory)}\\SFX\\intro.wav";
            intro.Load(); intro.Play();
        }
        public static void MusicaDeFondo()
        {
            TimeSpan terminar = new TimeSpan(0, 0, 0, 9, 92);
            
            MediaElement cancion = new MediaElement();
            cancion.Source = new Uri($"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory)}\\Music\\Let's be Honest.wav");
            
        }
        public static void SfxBtn()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = $"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory)}\\SFX\\over.wav";
            soundPlayer.Load(); soundPlayer.Play();
        }
        public static void SfxTxt()
        {
            SoundPlayer texto = new SoundPlayer();
            texto.SoundLocation = $"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory)}\\SFX\\click.wav";
            texto.Load(); texto.Play();
        }
        public static void SfxFlip()
        {
            SoundPlayer flip = new SoundPlayer();
            flip.SoundLocation = $"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory)}\\SFX\\flip.wav";
            flip.Load(); flip.Play();
        }
        public static void SfxRemove()
        {
            SoundPlayer remove = new SoundPlayer();
            remove.SoundLocation = $"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory)}\\SFX\\remove.wav";
            remove.Load(); remove.Play();
        }
        public static void SfxSlide()
        {
            SoundPlayer slide = new SoundPlayer();
            slide.SoundLocation = $"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory)}\\SFX\\slide.wav";
            slide.Load(); slide.Play();
        }
        public static void SfxCorrect()
        {
            SoundPlayer correct = new SoundPlayer();
            correct.SoundLocation = $"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory)}\\SFX\\correct.wav";
            correct.Load(); correct.Play();
        }
        public static void SfxError()
        {
            SoundPlayer error = new SoundPlayer();
            error.SoundLocation = $"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory)}\\SFX\\error.wav";
            error.Load(); error.Play();
        }
    }
}
