using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    abstract class Vehicle
    {
        public int Speed { get; set; }
        public int Capacity { get; set; }

        public Vehicle(int speed, int capacity)
        {
            Speed = speed;
            Capacity = capacity;
        }

        public abstract void Move();

    }
}

