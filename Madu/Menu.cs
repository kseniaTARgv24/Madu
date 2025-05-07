using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    class Menu
    {
        private static string[] menu_options = { "START" , "SETTINGS", "SCORE", "EXIT"};
        
        public List<int> ShowOptions()
        {
            int choice = Keyboard.ChooseOption("Main Menu", menu_options);
            switch (choice)
            {
                case 0: return SettingsOptions.DEFAULT.ToList();
                case 1: return Keyboard.ChooseOptionSettings("SETTINGS");
                //case 2: Score(); break;
                //case 3: Exit(); break;
                default:
                 return SettingsOptions.DEFAULT.ToList(); 
            }
        }
        public static bool GetDrunkMode(List<int> choises)
        {
            return SettingsOptions.DrunkMode[choises[0]];
        }

        public static int GetSpeed(List<int> choises)
        {
            return SettingsOptions.Speed[choises[1]];
        }

        public static string GetSymbol(List<int> choises)
        {
            return SettingsOptions.Symbol[choises[2]];
        }

        public static int GetSoundVolume(List<int> choises)
        {
            return SettingsOptions.SoundVolume[choises[3]];
        }

    }
}
