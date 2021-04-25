using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class shop
    {
        static void Main(string[] args)
        {
            Queue<int> boxOffice = new Queue<int>();
            int cash = 0;

            boxOffice.Enqueue(1000);
            boxOffice.Enqueue(10000);
            boxOffice.Enqueue(2000);
            boxOffice.Enqueue(22000);
            boxOffice.Enqueue(3000);
            boxOffice.Enqueue(44000);
            boxOffice.Enqueue(5000);
            boxOffice.Enqueue(55000);

            while (boxOffice.Count > 0)
            {
                Console.Clear();
                Console.WriteLine($"Hello! You have to pay {boxOffice.Peek()}");
                System.Threading.Thread.Sleep(500);
                Console.Write(". ");
                System.Threading.Thread.Sleep(500);
                Console.Write(". ");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(". ");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Thank you!");
                cash += boxOffice.Dequeue();
                Console.SetCursorPosition(0, 5);
                Console.WriteLine($"Shop's cash is {cash}");
                Console.ReadKey();
            }
        }
    }
}
