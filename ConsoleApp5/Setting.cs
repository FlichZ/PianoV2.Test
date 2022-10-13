using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Setting
    {
        public static void SettingInside()
        {
            Console.Clear();
            ConsoleKeyInfo key;
            int OctaveNum = 1;
            do
            {
                Console.WriteLine("F5 - уменьшить октаву на 1");
                Console.WriteLine("F6 - увеличить октаву на 1");
                Console.WriteLine("ESC - выйти");
                Console.WriteLine($"Текущая октава - {OctaveNum}");

                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.F5:
                        OctaveNum--;
                        if (OctaveNum == 0)
                        {
                            OctaveNum = 1;
                        }
                        break;
                    case ConsoleKey.F6:
                        OctaveNum++;
                        if (OctaveNum == 10)
                        {
                            OctaveNum = 9;
                        }
                        break;
                }
                Console.Clear();
                GlobalNum.Num = OctaveNum; 
            } while (key.Key != ConsoleKey.Escape);
        }
    }

}
