using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASProj.Utils
{
    public class MusicPlayer
    {

        private static IWavePlayer wOut = new WaveOut();
        public static void playResource(byte[] resource, float vol)
        {
            MemoryStream mp3 = new MemoryStream(resource);
            Mp3FileReader reader = new Mp3FileReader(mp3);
            wOut.Volume = vol;
            wOut.Init(reader);
            wOut.Play();
        }

        public static void stopResource()
        {
            wOut.Stop();
        }
    }
}
