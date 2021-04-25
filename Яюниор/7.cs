using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class _7
    {
        static void Main7(string[] args)
        {
            //Мы видим что вся последовательность это 7 умноженное на постоянно растущее число (n+1)
            int a = 7;
            int n = 1;
            int result = 1;
            while (result < 200)
            {
                result = a * n++;
                
                Console.Write(result + " ");
            }
        }
    }
}
