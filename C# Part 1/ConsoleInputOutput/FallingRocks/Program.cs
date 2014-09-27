using System;
using System.Collections.Generic;
using System.Threading;

class Game
{
    static void PrintCharacterOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Black)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Black)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    struct Dwarf
    {
        public int x, y;
        public string c;
    }

    class Stone
    {
        public int x, y;
        public char c;
        public ConsoleColor color;
    }

    static void Main()
    {
        //Initialization
        String[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));
        int numColors = colorNames.Length;
        Random random = new Random();
        string[] x = new string[] { "", "", "" };
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.Clear();
        int livesCount = 6;
        int startingSpeed = 400, speedIncrease = 0;
        int stonesPerTick = 1;
        bool hit = false;
        Dwarf dwarf = new Dwarf();
        dwarf.x = 36;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.c = "(0)";
        List<Stone> stones = new List<Stone>();
        List<char> symbols = new List<char>();
        symbols.Add('^');
        symbols.Add('@');
        symbols.Add('*');
        symbols.Add('&');
        symbols.Add('+');
        symbols.Add('%');
        symbols.Add('$');
        symbols.Add('#');
        symbols.Add('!');
        symbols.Add('.');
        symbols.Add(';');

        //Start Screen
        PrintStringOnPosition(15, 2, "You are a dwarf.");
        PrintStringOnPosition(15, 3, "You have to avoid the falling rocks.");
        PrintStringOnPosition(15, 4, "You move with the arrow keys.");
        PrintStringOnPosition(15, 5, "Lives: ");
        Console.WriteLine(livesCount);
        PrintStringOnPosition(15, 6, "The speed increases and as the game goes on it increases faster.");
        PrintStringOnPosition(15, 7, "Press any key to start...");
        Console.ReadKey();

        //Main Loop
        while (true)
        {
            hit = false;
            Console.Clear();

            //Advance Rocks
            ConsoleColor color;
            do
            {
                string colorName = colorNames[random.Next(numColors)];
                color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName);
            } while (color == Console.BackgroundColor);
            for (int i = 0; i < stonesPerTick; i++)
            {
                Stone newStone = new Stone();
                newStone.x = random.Next(0, Console.WindowWidth);
                newStone.y = 0;
                newStone.color = color;
                newStone.c = symbols[random.Next(0, 11)];
                stones.Add(newStone);
            }
            for (int i = 0; i < stones.Count; i++)
            {
                if (stones[i].y < Console.WindowHeight - 1)
                {
                    stones[i].y++;
                    PrintCharacterOnPosition(stones[i].x, stones[i].y, stones[i].c, stones[i].color);
                }
                else
                {
                    stones.Remove(stones[i]);
                }

                //Check Collision
                if (((stones[i].x == dwarf.x - 1) || (stones[i].x == dwarf.x) || (stones[i].x == dwarf.x + 1)) && (stones[i].y == dwarf.y))
                {
                    livesCount--;
                    hit = true;
                    Console.Beep(5000, 500);
                    if (livesCount < 1)
                    {
                        Console.Clear();
                        PrintStringOnPosition(33, 10, "Game Over!");
                        Console.SetCursorPosition(25,11);
                        Environment.Exit(0);
                    }
                    else
                    {
                        stones.Clear();
                    }
                }

            }

            //Handle Input
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = new ConsoleKeyInfo();
                pressedKey = Console.ReadKey();
                while (Console.KeyAvailable)
                {
                    Console.ReadKey();
                }
                if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x < Console.WindowWidth - 2)
                    {
                        dwarf.x++;
                    }
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x > 1)
                    {
                        dwarf.x--;
                    }
                }
            }

            //Print Character
            PrintCharacterOnPosition(dwarf.x - 1, dwarf.y, dwarf.c[0]);
            PrintCharacterOnPosition(dwarf.x, dwarf.y, dwarf.c[1]);
            PrintCharacterOnPosition(dwarf.x + 1, dwarf.y, dwarf.c[2]);

            //Print Status
            PrintStringOnPosition(56, 2, "Lives: ");
            Console.WriteLine(livesCount);
            PrintStringOnPosition(56, 3, "Speed: ");
            Console.WriteLine(speedIncrease);

            if (startingSpeed - speedIncrease > 50)
            {
                speedIncrease++;
            }
            if (speedIncrease == 150)
            {
                stonesPerTick = 2;
            }
            if (speedIncrease == 300)
            {
                stonesPerTick = 3;
            }
            if (speedIncrease == 350 && stonesPerTick != 4)
            {
                stonesPerTick = 4;
            }
            Thread.Sleep(startingSpeed - speedIncrease);
        }
    }
}
