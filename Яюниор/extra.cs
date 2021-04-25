using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class extra
    {
        static void Main(string[] args)
        {
            char[,] map =
            {
                {'_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_'},
                {'|', ' ', ' ', ' ', '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
                {'|', ' ', ' ', ' ', '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
                {'|', ' ', '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|'},
                {'|', ' ', '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', '|', ' ', ' ', '|'},
                {'|', ' ', '|', ' ', ' ', ' ', ' ', '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|', ' ', ' ', '|'},
                {'|', ' ', '|', ' ', ' ', ' ', ' ', '|', ' ', '|', ' ', ' ', 'X', '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|'},
                {'|', 'X', '|', ' ', '|', ' ', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|'},
                {'|', '~', '~', '~', '|', ' ', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', ' ', '|', ' ', '|', ' ', ' ', '|'},
                {'|', 'X', '|', ' ', '|', ' ', ' ', '|', 'X', '|', ' ', '|', ' ', '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', '|'},
                {'|', ' ', '|', ' ', ' ', ' ', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', ' ', '|', ' ', '|', ' ', ' ', '|'},
                {'|', ' ', '|', ' ', ' ', ' ', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', ' ', '|', ' ', '|', ' ', ' ', '|'},
                {'|', ' ', '|', ' ', '|', ' ', ' ', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', 'X', '|', ' ', '|', ' ', ' ', '|'},
                {'|', ' ', '|', ' ', '|', ' ', ' ', '|', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '|', '_', '_', '|'},
                {'|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', 'X', '|'},
                {'|', ' ', ' ', ' ', '|', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', '|'},
                {'~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~'}
            };
            int userX = 8;
            int userY = 8;

            Console.CursorVisible = false;
            while (true)
            {
                Console.SetCursorPosition(0, 20);
                char[] bag = new char[1];
                Console.Write("Сумка: ");
                for (int i = 0; i < bag.Length; i++)
                {
                    Console.Write(bag[i] + " ");
                }
                Console.SetCursorPosition(0, 0);

                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(userY, userX);
                Console.Write("@");
                ConsoleKeyInfo userInput = Console.ReadKey();
                switch (userInput.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[userX - 1, userY] != '|' && map[userX - 1, userY] != '~' && map[userX - 1, userY] != '_') 
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userX + 1, userY] != '|' && map[userX + 1, userY] != '~' && map[userX + 1, userY] != '_')
                        {
                            userX++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[userX, userY - 1] != '|' && map[userX, userY - 1] != '~' && map[userX, userY - 1] != '_')
                        {
                            userY--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userX, userY + 1] != '|' && map[userX, userY + 1] != '~' && map[userX, userY + 1] != '_')
                        {
                            userY++;
                        }
                        break;
                }

                if (map[userX, userY] == 'X')
                {
                    map[userX, userY] = 'o';

                    char[] newBag = new char[bag.Length + 1];
                    for (int i = 0;i < bag.Length; i++)
                    {
                        newBag[i] = bag[i];
                    }
                    newBag[newBag.Length - 1] = 'X';
                    bag[bag.Length - 1] = 'X';
                    bag = newBag;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
