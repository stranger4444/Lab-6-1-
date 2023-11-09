using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Train:Vehicle
    {
        public string TrainNumber { get; set; }

        public Train(int speed, int capacity, string trainNumber) : base(speed, capacity)
        {
            TrainNumber = trainNumber;
        }

        public override void Move()
        {
            Console.WriteLine($"Train ({TrainNumber}) is moving at a speed of {Speed} km/h.");
        }
    }
}
