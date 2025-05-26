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
            while (true)
            {
                int choice = Keyboard.ChooseOption("Main Menu", menu_options);
                switch (choice)
                {
                    case 0:
                        return SettingsOptions.DEFAULT.ToList();

                    case 1: 
                        return Keyboard.ChooseOptionSettings("SETTINGS");

                    case 2: 
                        Score();
                        break;

                    case 3: 
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
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

        public void Score()
        {
            Console.Clear();
            string path = "scores.txt";
            //Console.WriteLine(Path.GetFullPath(path));////////////

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                Console.WriteLine("Scores:\n");

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("file made");
            }

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }


    }
}
