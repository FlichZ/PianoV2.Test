namespace ConsoleApp5
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            int winWidth;
            int winHeight;
            winWidth = Console.WindowWidth;
            winHeight = Console.WindowHeight;
            Console.CursorVisible = false;

            int select = 0;


            List<Tuple<int, int, string, Boolean>> options = new()
            {
                    new Tuple<int, int, string, Boolean>((winWidth/2)-7, (winHeight / 2) - 2, "Зайти в пианино", true),
                    new Tuple<int, int, string, Boolean>((winWidth/2)-4, (winHeight / 2) - 1, "Настройка", false),
                    new Tuple<int, int, string, Boolean>((winWidth/2)-2, (winHeight / 2) , "Выход", false),
            };

            while (true)
            {
                Console.Clear();
                foreach (Tuple<int, int, string, Boolean> textWrite in options)
                {
                    if (textWrite.Item4 == true)
                    {
                        select = options.FindIndex(t => t.Item3 == textWrite.Item3);
                        Console.SetCursorPosition(textWrite.Item1, textWrite.Item2);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(textWrite.Item3);
                    }
                    else if (textWrite.Item4 == false)
                    {
                        Console.SetCursorPosition(textWrite.Item1, textWrite.Item2);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(textWrite.Item3);
                    }
                }

                Console.SetCursorPosition(options[2].Item1 + 1, options[2].Item2);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;

                string inputKey = Console.ReadKey().Key.ToString();


                if (inputKey == "UpArrow" && select > 0)
                {
                    options[select] = new Tuple<int, int, string, bool>(options[select].Item1, options[select].Item2, options[select].Item3, false);
                    select -= 1;
                    options[select] = new Tuple<int, int, string, bool>(options[select].Item1, options[select].Item2, options[select].Item3, true);
                }
                else if (inputKey == "RightArrow")
                {
                    SwitchInterface.Inside(select);
                }
                else if (inputKey == "DownArrow" && select < 3)
                {
                    options[select] = new Tuple<int, int, string, bool>(options[select].Item1, options[select].Item2, options[select].Item3, false);
                    select += 1;
                    options[select] = new Tuple<int, int, string, bool>(options[select].Item1, options[select].Item2, options[select].Item3, true);
                }

            }
        }

    }
}