﻿using System;
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


        WaveOut output = null;

        public void Play()
        {
            string assemblyPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\sounder\explosion.mp3";


            string _outPath_ = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\sounder\explosion.wav";


            if (!File.Exists(_outPath_))
            {

                using (Mp3FileReader mp3 = new Mp3FileReader(assemblyPath))
                {
                    using (WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
                    {
                        WaveFileWriter.CreateWaveFile(_outPath_, pcm);
                    }
                }
            }
        
            // 0 == defulet
            playSound(0, _outPath_);

        }

        /// <summary>
        /// play sound 
        /// </summary>
        /// <param name="deviceNumber">device to play on</param>
        /// <param name="path">path to file</param>
        public void playSound(int deviceNumber , string path)
        {
            this.disposeWave();

            var waveReader = new NAudio.Wave.WaveFileReader(path);
            var waveOut = new NAudio.Wave.WaveOut();
            waveOut.DeviceNumber = deviceNumber;
            output = waveOut;
            output.Init(waveReader);
            output.Play();
        }

        /// <summary>
        /// end sound 
        /// </summary>
        public void disposeWave()
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                    output.Stop();
                    output.Dispose();
                    output = null;
                }
            }

        }


    }
}
