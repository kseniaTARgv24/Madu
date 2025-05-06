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
        
        public void ShowOptions()
        {
            int choice = Keyboard.ChooseOption("Main Menu", menu_options);
            switch (choice)
            {
                case 0: break;
                case 1: Settings.OpenSettings(); break;
                //case 2: Score(); break;
                //case 3: Exit(); break;
            }
        }
    }
}
