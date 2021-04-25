using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class _5
    {
        static void Main5(string[] args)
        {
            int oldLedies;
            int waitingperson = 10;
            int waitingTime;
            int waitingMinute;
            int waitingHour;
            Console.WriteLine("Сколько перед вами старушек?");
            oldLedies = Convert.ToInt32(Console.ReadLine());
            waitingTime = oldLedies * waitingperson;
            waitingHour = waitingTime / 60;
            waitingMinute = waitingTime % 60;
            Console.WriteLine("На " + oldLedies + " старушек вам потребуется " + waitingHour + " часов " + waitingMinute + " минут.");
        }
    }
}
