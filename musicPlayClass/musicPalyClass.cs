using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.IO;
using System.Windows.Forms;

using Accord.DirectSound;

namespace musicPlayClass
{
    public class musicPalyClass
    {


        public musicPalyClass()
        {

        }


        WaveOut output = null;
        /// <summary>
        /// to add or set a new Sound to system 
        /// </summary>
        /// <param name="number">number to key new Sound set to</param>
        /// <param name="path">path to Sound </param>
        public void setNewSound(byte number,string path)
        {
            try
            {
                string assemblyPath = path;


                string _outPath_ = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\sounder\Sound" + number + ".wav";


                //if (!File.Exists(_outPath_))
                //{

                    using (Mp3FileReader mp3 = new Mp3FileReader(assemblyPath))
                    {
                        using (WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
                        {
                            WaveFileWriter.CreateWaveFile(_outPath_, pcm);
                        }
                    }
                //}
            }
            catch
            {
                MessageBox.Show("error","error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// play sound 
        /// </summary>
        /// <param name="deviceNumber">device to play on. 0  == defulet</param>
        /// <param name="path">path to file</param>
        public void playSound(int deviceNumber , byte number)
        {
            try
            {
                this.disposeWave();

                string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\sounder\Sound" + number + ".wav";

                var waveReader = new NAudio.Wave.WaveFileReader(path);
                var waveOut = new NAudio.Wave.WaveOut();
                waveOut.DeviceNumber = deviceNumber;
                output = waveOut;
                output.Init(waveReader);
                output.Play();
            }
            catch
            { }
        }

        /// <summary>
        /// end sound 
        /// </summary>
        public void disposeWave()
        {
            try
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
            catch { }

        }




        public List<deviceName> getOutPutList()
        {
            var collection = new AudioDeviceCollection(AudioDeviceCategory.Output);

            List<deviceName> deviceList = new List<deviceName>();

            bool first = true;

            foreach (var device in collection)
            {
                if(first)
                { first = false;
                    continue;
                }


                deviceList.Add(new deviceName(device.Guid.ToString(), device.ToString()));
              
            }



            return deviceList;
        }


        public int getOutPut(string Guid)
        {
            var collection = new AudioDeviceCollection(AudioDeviceCategory.Output).ToList();


            return collection.FindIndex(device => device.Guid.ToString() == Guid);
        }




    }
}







public class deviceName
{
   public string name { get; private set; }

   public string Guid { get; private set; }




    public deviceName(string Guid,string name)
    {
        this.name = name;
        this.Guid = Guid;
    }



}
