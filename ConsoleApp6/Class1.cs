using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Class1
    {
        public void Screen()
        {
            for (int i = 30; i <= 79; i++)
            {
                Console.SetCursorPosition(i, 0); Console.Write("═");
                Console.SetCursorPosition(i, 25); Console.Write("═");
                Console.SetCursorPosition(i,4);Console.Write("*");
                Console.SetCursorPosition(i,8); Console.Write("*");
                Console.SetCursorPosition(i,12); Console.Write("*");

            }

            for (int i = 1; i <= 24; i++)
            {
                Console.SetCursorPosition(30,i ); Console.Write("║");
                Console.SetCursorPosition(80, i); Console.Write("║");
            }

            Console.SetCursorPosition(30,0); Console.Write("╔");
            Console.SetCursorPosition(80,0 ); Console.Write("╗");
            Console.SetCursorPosition(30,25); Console.Write("╚");
            Console.SetCursorPosition(80,25); Console.Write("╝");


        }


    }
}
