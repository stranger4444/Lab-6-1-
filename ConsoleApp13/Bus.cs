using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Bus:Vehicle
    {
        public int PassengerCount { get; set; }

        public Bus(int speed, int capacity) : base(speed, capacity)
        {
            PassengerCount = 0;
        }

        public override void Move()
        {
            Console.WriteLine($"Bus with {PassengerCount} passengers is moving at a speed of {Speed} km/h.");
        }

        public void BoardPassenger()
        {
            if (PassengerCount < Capacity)
            {
                PassengerCount++;
                Console.WriteLine("Passenger boarded.");
            }
            else
            {
                Console.WriteLine("Bus is full. Cannot board more passengers.");
            }
        }
        public void AlightPassenger()
        {
            if (PassengerCount > 0)
            {
                PassengerCount--;
                Console.WriteLine("Passenger alighted.");
            }
            else
            {
                Console.WriteLine("No passengers to alight.");
            }
        }
    }
}
