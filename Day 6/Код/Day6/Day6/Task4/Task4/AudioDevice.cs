using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class AudioDevice : ISpeaker, IMicrophone
    {
        void ISpeaker.AdjustVolume(int level)
        {
            Console.WriteLine($"Громкость динамика отрегулирована до {level}");
        }

        void IMicrophone.AdjustVolume(int level)
        {
            Console.WriteLine($"Громкость микрофона настроена на {level}");
        }
    }
}
