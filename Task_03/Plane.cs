using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Plane : Vehicle
    {
        private double height;
        private int passengers;

        public Plane(double coordinatesX, double coordinatesY, double price, double speed, int year, double height, int passengers)
        : base(coordinatesX, coordinatesY, price, speed, year)
        {
            this.height = height;
            this.passengers = passengers;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Висота: {height} м");
            Console.WriteLine($"Пасажири: {passengers}");
        }
    }
}
