using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class TransportNetwork
    {
        private List<Vehicle> vehicles;

        public TransportNetwork()
        {
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void ControlMovement()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.Move();

                if (vehicle is Bus)
                {
                    var bus = (Bus)vehicle;
                    bus.BoardPassenger();
                    bus.AlightPassenger();
                }
            }


        }
        public string CalculateOptimalRoute(Route route, Vehicle vehicle)
        {
            return $"Optimal route from {route.StartPoint} to {route.EndPoint} for {vehicle.GetType().Name}.";
        }
    }
}
