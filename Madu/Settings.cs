using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    class Settings
    {
        private static string[] settings_option = { "SPEED", "SNAKE DESIGN", "SOUND VOLUME" };
        public static void OpenSettings()
        {
            List<int> choises = Keyboard.ChooseOptionSettings("SETTINGS");
            //switch(choise)
            //{
            //    case 0:
            //}

         
        }


    }
}
