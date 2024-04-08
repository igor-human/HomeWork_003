using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    internal class ColorPrinter : Printer
    {
        public new void Print(string value)
        {
            // Генерація випадкового числа для вибору кольору
            Random random = new Random();
            ConsoleColor color = (ConsoleColor)random.Next(1, 16);

            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
