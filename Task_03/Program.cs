using System;
using System.Text;
using Task_03;




namespace Classes
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = UnicodeEncoding.Unicode;

            Plane plane = new Plane(10, 10, 20000000, 400, 1996, 30, 55);
            Car car = new Car(5, 5, 250000, 250, 2006);
            Ship ship = new Ship(15, 15, 500000, 35, 1955, 12, "Одеса");

            Console.WriteLine("Літак: ");
            plane.ShowInfo();

            Console.WriteLine("\nМашина: ");
            car.ShowInfo();

            Console.WriteLine("\nКорабель: ");
            ship.ShowInfo(); 

            // Delay.
            Console.ReadKey();
        }
    }
}
