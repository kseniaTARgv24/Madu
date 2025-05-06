using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    class SettingsOptions
    {
        public static string[] SettingsOptionsList = { "DRUNK MODE", "SPEED", "SYMBOL", "SOUND VOLUME" };   
        public static bool[] DrunkMode = {true, false};
        public static int[] Speed = { 100, 200, 300 };
        public static string[] Symbol = { "*", "#", "@", "&" };
        public static int[] SoundVolume = Enumerable.Range(0, 101).ToArray();


    }
}
