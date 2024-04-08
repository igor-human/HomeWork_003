using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Vehicle
    {
        protected double coordinatesX;
        protected double coordinatesY;
        protected double price;
        protected double speed;
        protected int year;

        public Vehicle(double coordinatesX, double coordinatesY, double price, double speed, int year)
        {
            this.coordinatesX = coordinatesX;
            this.coordinatesY = coordinatesY;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Кординати: ({coordinatesX}, {coordinatesY})");
            Console.WriteLine($"Ціна: {price} грн");
            Console.WriteLine($"Швидкість: {speed} км/год");
            Console.WriteLine($"Рік: {year}");
        }
    }
}
