using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class GamerDrawer
    {
        static void Main(string[] args)
        {
            Drawer drawer = new Drawer();
            Random random = new Random();
            List<char> bodyKinds = new List<char> { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '~', '?', '/'};
            List<ConsoleColor> colors = new List<ConsoleColor> { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.White, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan};
            bool open = true;

            Console.CursorVisible = false;

            while (open)
            {
                Gamer gamer = new Gamer(random.Next(100), random.Next(30), bodyKinds[random.Next(bodyKinds.Count)]);
                
                drawer.DrawGamer(gamer, colors[random.Next(colors.Count)]);

                Console.ReadKey();
            }
        }
    }

    class Drawer
    {
        private ConsoleColor _defaultColor;

        public Drawer()
        {
            _defaultColor = Console.ForegroundColor;
        }

        public void DrawGamer(Gamer gamer, ConsoleColor color)
        {
            Console.SetCursorPosition(gamer.X, gamer.Y);

            Console.ForegroundColor = color;
            Console.Write(gamer.Body);
            Console.ForegroundColor = _defaultColor;
        }
    }

    class Gamer
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public char Body { get; private set; }

        public Gamer(int x, int y, char body)
        {
            X = x;
            Y = y;
            Body = body;
        }
    }
}
