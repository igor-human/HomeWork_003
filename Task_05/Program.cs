using System;
using System.Text;
using Task_05;



namespace Classes
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = UnicodeEncoding.Unicode;

            Printer printer = new Printer();
            printer.Print("Цей текст буде виведений білим кольором");

            ColorPrinter colorPrinter = new ColorPrinter();
            colorPrinter.Print("Цей текст буде виведений різними кольорами");


            // Delay.
            Console.ReadKey();
        }
    }
}
