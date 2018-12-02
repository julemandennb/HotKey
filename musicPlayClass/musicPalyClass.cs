using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.IO;


namespace musicPlayClass
{
    public class musicPalyClass
    {


        public musicPalyClass()
        {

        }

        NAudio.Wave.WaveIn sourceStream = null;
        NAudio.Wave.DirectSoundOut waveOut = null;

        public void Play()
        {
            string assemblyPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\sounder\explosion.mp3";


                AudioFileReader audio = new AudioFileReader(assemblyPath);

                IWavePlayer player = new WaveOut(WaveCallbackInfo.FunctionCallback());
                player.Init(audio);
                player.Play();





            

        }


    }
}
