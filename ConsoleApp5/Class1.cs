using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp5.Setting;

namespace ConsoleApp5
{

    internal class Piano
    {
        public static void pianoApp()
        {
            Console.Clear();
            int line = 1;
            Line Octave = new Line();
            line = Octave.lineOctave;
            ConsoleKeyInfo key;
            int[,] octavesNotes = new int[,] { { 16, 17, 18, 19, 20, 21, 23, 24, 25, 27, 29, 30 },
                                                  { 32, 34, 36, 38, 41, 43, 46, 49, 51, 55, 58, 61 },
                                                { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 },
                                            { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 },
                                            { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 593 },
                                            { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 },
                                      { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 },
                                      { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 },
                                      { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 }};
            do
            {
                Console.WriteLine("ESC - выход из программы");
                Console.WriteLine($"Текущая октава - {line+1}");

                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.A:
                        Voice(octavesNotes[line, 0]);
                        break;
                    case ConsoleKey.B:
                        Voice(octavesNotes[line, 1]);
                        break;
                    case ConsoleKey.C:
                        Voice(octavesNotes[line, 2]);
                        break;
                    case ConsoleKey.D:
                        Voice(octavesNotes[line, 3]);
                        break;
                    case ConsoleKey.E:
                        Voice(octavesNotes[line, 4]);
                        break;
                    case ConsoleKey.F:
                        Voice(octavesNotes[line, 5]);
                        break;
                    case ConsoleKey.G:
                        Voice(octavesNotes[line, 6]);
                        break;
                    case ConsoleKey.H:
                        Voice(octavesNotes[line, 7]);
                        break;
                    case ConsoleKey.I:
                        Voice(octavesNotes[line, 8]);
                        break;
                    case ConsoleKey.J:
                        Voice(octavesNotes[line, 9]);
                        break;
                    case ConsoleKey.K:
                        Voice(octavesNotes[line, 10]);
                        break;
                    case ConsoleKey.L:
                        Voice(octavesNotes[line, 11]);
                        break;
                }
                Console.Clear();
            } while (key.Key != ConsoleKey.Escape);


        }

        public static void Voice(int note)
        {
            if (note < 37)
            {
                note = 37;
            }
            Console.Beep(note, 250);
        }
    }
}
