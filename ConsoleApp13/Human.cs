using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Human:Vehicle
    {
        public Human(int speed) : base(speed, 1) { }

        public override void Move()
        {
            Console.WriteLine($"Human is walking at a speed of {Speed} km/h.");
        }
    }

}

