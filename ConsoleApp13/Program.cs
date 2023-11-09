using ConsoleApp13;

class Program
{
    static void Main()
    {
        Human person = new Human(5);
        Car car = new Car(60, 4, "Sedan");
        Bus bus = new Bus(40, 30);
        Train train = new Train(100, 150, "Express");

        TransportNetwork network = new TransportNetwork();
        network.AddVehicle(person);
        network.AddVehicle(car);
        network.AddVehicle(bus);
        network.AddVehicle(train);

        network.ControlMovement();

        Route route = new Route("City A", "City B");
        string optimalRoute = network.CalculateOptimalRoute(route, train);

        Console.WriteLine(optimalRoute);
    }
}