using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AudioDevice audioDevice = new AudioDevice();

            ISpeaker speaker = audioDevice;
            IMicrophone microphone = audioDevice;

            speaker.AdjustVolume(10);
            microphone.AdjustVolume(5);
        }
    }
}
