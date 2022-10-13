using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public static class SwitchInterface
    {
        public static void Inside(int select)
        {
            switch (select)
            {
                case 0:
                    Piano.pianoApp();
                    break; 
                case 1:
                     Setting.SettingInside();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
