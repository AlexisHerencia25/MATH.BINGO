using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using NAudio.Wave;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class Metodos
    {
        public static void MusicaDeFondo()
        {
            using (var audioFile = new AudioFileReader(audioFilePath))
            {
                TimeSpan duration = audioFile.TotalTime;
                Console.WriteLine($"Duración del archivo MP3: {duration}");
            }
        }
        public static void SfxBtn()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = $"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory)}\\SFX\\Slide.wav";
            soundPlayer.Load(); soundPlayer.Play();
        }
    }
}
