using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Ship : Vehicle
    {
        private int passengers;
        private string homePort;

        // Конструктор для класу Ship
        public Ship(double coordinatesX, double coordinatesY, double price, double speed, int year, int passengers, string homePort)
            : base(coordinatesX, coordinatesY, price, speed, year)
        {
            this.passengers = passengers;
            this.homePort = homePort;
        }

        // Перевизначення методу ShowInfo для класу Ship
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Пассажири: {passengers}");
            Console.WriteLine($"Домашній порт: {homePort}");
        }
    }
}
