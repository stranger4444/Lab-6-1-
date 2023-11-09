using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Car:Vehicle
    {
        public string Model { get; set; }

        public Car(int speed, int capacity, string model) : base(speed, capacity)
        {
            Model = model;
        }

        public override void Move()
        {
            Console.WriteLine($"Car ({Model}) is driving at a speed of {Speed} km/h.");
        }

    }
}
