using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Car : Vehicle
    {
        public Car(double coordinatesX, double coordinatesY, double price, double speed, int year)
        : base(coordinatesX, coordinatesY, price, speed, year)
        {
        }
    }
}
